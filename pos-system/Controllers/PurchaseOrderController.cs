using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pos_system.Data;
using pos_system.Models.CustomEntities;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public PurchaseOrderController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getPOrders()
        {
            var porders = dbContext.PurchaseOrder
            .Include(o => o.PurchaseOrderItems)
                .ThenInclude(i => i.Product)
            .Include(o => o.Supplier)
            .ToList();


            var result = porders.Select(o => new
            {
                o.Id,
                o.SupplierId,
                o.OrderDate,
                o.DeliveryDate,
                o.Supplier,
                Items = o.PurchaseOrderItems.Select(i => new
                {
                    i.ProductId,
                    i.CostPrice,
                    i.Quantity,
                    i.ItemTotalAmount,
                    i.Product
                }).ToList()
            }).ToList();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getPOrderById(int id)
        {
            var po = dbContext.PurchaseOrder
                .Include(o => o.Supplier)
                .Include(o => o.PurchaseOrderItems)
                    .ThenInclude(i => i.Product)
                .Where(o => o.Id == id)
                .Select(o => new
                {
                    o.Id,
                    o.SupplierId,
                    o.OrderDate,
                    o.DeliveryDate,
                    o.Supplier,
                    Items = o.PurchaseOrderItems.Select(i => new
                    {
                        i.ProductId,
                        i.CostPrice,
                        i.Quantity,
                        i.ItemTotalAmount,
                        i.Product
                    }).ToList()
                })
                .FirstOrDefault();

            if (po is null) return NotFound($"Purchase Order with ID {id} not found.");

            return Ok(po);
        }

        [HttpPost]
        public IActionResult AddPOrder([FromBody] POrder purchaseOrder)
        {
            using var transaction = dbContext.Database.BeginTransaction();
            try
            {
                // Validate that the purchase order contains at least one product
                if (purchaseOrder.Items == null || !purchaseOrder.Items.Any())
                {
                    return BadRequest("The purchase order must contain at least one product.");
                }

                // Create PurchaseOrder
                var pOrder = new PurchaseOrder
                {
                    SupplierId = purchaseOrder.SupplierId,
                    DeliveryDate = purchaseOrder.DeliveryDate,
                    OrderDate = DateTimeOffset.Now
                };

                dbContext.PurchaseOrder.Add(pOrder);
                dbContext.SaveChanges();

                //validate purchase order : need atleast one product
                
                // Add PurchaseOrderItems
                foreach (var item in purchaseOrder.Items)
                {
                    var orderItem = new PurchaseOrderItems
                    {
                        PurchaseOrderId = pOrder.Id,
                        ProductId = item.ProductId,
                        CostPrice = item.CostPrice,
                        Quantity = item.Quantity,
                        ItemTotalAmount = (item.CostPrice * item.Quantity)
                    };

                    dbContext.PurchaseOrderItems.Add(orderItem);
                }

                dbContext.SaveChanges();

                transaction.Commit();
                return Ok(purchaseOrder);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return StatusCode(500, "An error occurred while processing the purchase order.");
            }
        }

        [HttpPut]
        public IActionResult UpdatePOrder(int id, POrder po)
        {
            // Fetch the existing PurchaseOrder by ID
            var existingPOrder = dbContext.PurchaseOrder
                .Include(o => o.PurchaseOrderItems) // Include PurchaseOrderItems for updates
                .FirstOrDefault(o => o.Id == id);

            if (existingPOrder is null)
            {
                return NotFound($"Purchase Order with ID {id} not found.");
            }

            // Update PurchaseOrder details
            existingPOrder.SupplierId = po.SupplierId;
            existingPOrder.DeliveryDate = po.DeliveryDate;

            // Update PurchaseOrderItems
            foreach (var item in po.Items)
            {
                // Check if the item exists in the existing purchase order
                var existingItem = existingPOrder.PurchaseOrderItems
                    .FirstOrDefault(i => i.ProductId == item.ProductId);

                if (existingItem != null)
                {
                    // Update existing item
                    existingItem.CostPrice = item.CostPrice;
                    existingItem.Quantity = item.Quantity;
                    existingItem.ItemTotalAmount = (item.CostPrice * item.Quantity);
                } 
                else
                {
                    // Add new item
                    existingPOrder.PurchaseOrderItems.Add(new PurchaseOrderItems
                    {
                        ProductId = item.ProductId,
                        CostPrice = item.CostPrice,
                        Quantity = item.Quantity,
                        ItemTotalAmount = (item.CostPrice * item.Quantity),
                        PurchaseOrderId = existingPOrder.Id
                    });
                }
            }

            // Remove any items that were not included in the updated request
            var itemsToRemove = existingPOrder.PurchaseOrderItems
                .Where(i => !po.Items.Any(u => u.ProductId == i.ProductId))
                .ToList();

            foreach (var item in itemsToRemove)
            {
                dbContext.PurchaseOrderItems.Remove(item);
            }

            dbContext.SaveChanges();
            return Ok(existingPOrder);
        }

        [HttpDelete]
        public IActionResult DeletePOrder(int id)
        {
            // Fetch the purchase order along with its items
            var po = dbContext.PurchaseOrder
                .Include(o => o.PurchaseOrderItems)
                .FirstOrDefault(o => o.Id == id);

            if (po is null)
                return NotFound($"Purchase Order with ID {id} not found.");

            // Remove the purchase order items first
            dbContext.PurchaseOrderItems.RemoveRange(po.PurchaseOrderItems);

            // Remove the purchase order
            dbContext.PurchaseOrder.Remove(po);

            // Save changes
            dbContext.SaveChanges();

            return Ok(po);
        }
    }
}
