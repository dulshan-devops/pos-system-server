using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pos_system.Data;
using pos_system.Models.CustomEntities;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public TransactionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getTransactions()
        {
            try
            {
                var transactions = dbContext.Transaction
                .Include(o => o.TransactionType)
                .Include(o => o.TransactionItem)
                    .ThenInclude(i => i.Product)
                .ToList();

                var result = transactions.Select(o => new
                {
                    o.TransactionId,
                    o.TransactionCode,
                    o.Discount,
                    o.Date,
                    TransactionType = o.TransactionType,
                    TransactionItems = o.TransactionItem
                }).ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddTransaction([FromBody] CTransaction addTransaction)
        {
            using var transaction = dbContext.Database.BeginTransaction();
            try
            {
                // Validate that the purchase order contains at least one product
                if (addTransaction.Items == null || !addTransaction.Items.Any())
                {
                    return BadRequest("The transaction must contain at least one product.");
                }

                var trns = new Transaction
                {
                    TransactionCode = addTransaction.TransactionCode,
                    TransactionTypeId = 1,
                    Discount = addTransaction.Discount,
                    Date = addTransaction.Date
                };

                dbContext.Transaction.Add(trns);
                dbContext.SaveChanges();

                foreach (var item in addTransaction.Items)
                {
                    var transactionItem = new TransactionItem
                    {
                        TransactionId = trns.TransactionId,
                        ProductId = item.ProductId,
                        CostPrice = item.CostPrice,
                        SPrice = item.SPrice,
                        WPrice = item.WPrice,
                        Qty = item.Qty,
                        Discount = item.Discount,
                        ItemTotal = (item.CostPrice * item.Qty)
                    };
                    dbContext.TransactionItem.Add(transactionItem);
                }

                dbContext.SaveChanges();

                transaction.Commit();
                return Ok(trns);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return BadRequest(ex.Message);
            }
        }
    }
}