using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pos_system.Data;
using pos_system.Migrations;
using pos_system.Models.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;
using Product = pos_system.Models.Entities.Product;
using ProductWarrantyPeriod = pos_system.Models.Entities.ProductWarrantyPeriod;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getProducts()
        {
            var products = dbContext.Products
            .Include(p => p.Department)
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .ToList();

            var result = products.Select(p => new
            {
                p.ProductId,
                p.ProductCode,
                p.ProductName,
                p.DepartmentId,
                p.CategoryId,
                p.SupplierId,
                p.CostPrice,
                p.SellingPrice,
                p.WholesalePrice,
                p.MarkedPrice,
                p.Warranty,
                p.Desc,
                p.Unit,
                Department = new
                {
                    p.Department?.DepartmentId,
                    p.Department?.DepartmentName,
                    p.Department?.Desc
                },
                Category = new
                {
                    p.Category?.CategoryId,
                    p.Category?.Name,
                    p.Category?.Desc
                },
                Supplier = new
                {
                    p.Supplier?.SupplierId,
                    p.Supplier?.SupplierName,
                    p.Supplier?.ContactPerson,
                    p.Supplier?.Email,
                    p.Supplier?.Mobile1,
                    p.Supplier?.Mobile2,
                    p.Supplier?.Address,

                }
            }).ToList();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getProductById(int id)
        {
            var product = dbContext.Products.Find(id);

            if (product is null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        [Route("{warrantyPeriod?}")]
        public IActionResult AddProducts(Product addProduct , int warrantyPeriod)
        {
            // Create the product object
            var product = new Product()
            {
                ProductCode = addProduct.ProductCode,
                ProductName = addProduct.ProductName,
                DepartmentId = addProduct.DepartmentId,
                CategoryId = addProduct.CategoryId,
                SupplierId = addProduct.SupplierId,
                CostPrice = addProduct.CostPrice,
                SellingPrice = addProduct.SellingPrice,
                WholesalePrice = addProduct.WholesalePrice,
                MarkedPrice = addProduct.MarkedPrice,
                Warranty = addProduct.Warranty,
                Desc = addProduct.Desc,
                Unit = addProduct.Unit
            };

            // Save the product to the database to generate ProductId
            dbContext.Products.Add(product);
            dbContext.SaveChanges(); // ProductId is generated here

            // Ensure that ProductId has been generated
            if (product.ProductId == 0)
            {
                throw new Exception("ProductId not generated.");
            }

            // If the product has a warranty, add the ProductWarrantyPeriod
            if (product.Warranty == 1)
            {
                // Verify that the warranty period is valid
                if (warrantyPeriod <= 0)
                {
                    throw new Exception("Please provide a valid warranty period for this product.");
                }

                var productWarrantyPeriod = new ProductWarrantyPeriod()
                {
                    ProductId = product.ProductId, // Use the generated ProductId
                    WarrantyPeriod = warrantyPeriod
                };

                dbContext.ProductWarrantyPeriod.Add(productWarrantyPeriod);
                dbContext.SaveChanges(); // Save ProductWarrantyPeriod
            }

            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(int id, Product updateProduct)
        {
            var product = dbContext.Products.Find(id);

            if (product is null) return NotFound();

                product.ProductCode = updateProduct.ProductCode;
                product.ProductName = updateProduct.ProductName;
                product.DepartmentId = updateProduct.DepartmentId;
                product.CategoryId = updateProduct.CategoryId;
                product.SupplierId = updateProduct.SupplierId;
                product.CostPrice = updateProduct.CostPrice;
                product.SellingPrice = updateProduct.SellingPrice;
                product.WholesalePrice = updateProduct.WholesalePrice;
                product.MarkedPrice = updateProduct.MarkedPrice;
                product.Warranty = updateProduct.Warranty;
                product.Desc = updateProduct.Desc;
                product.Unit = updateProduct.Unit;

            dbContext.SaveChanges();
            return Ok(product);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var product = dbContext.Products.Find(id);

            if (product is null) return NotFound();

            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            return Ok(product);
        }
    }
}
