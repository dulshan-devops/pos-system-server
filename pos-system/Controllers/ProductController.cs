using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pos_system.Data;
using pos_system.Migrations;
using pos_system.Models.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;
using Product = pos_system.Models.Entities.Product;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;
        public JsonSerializerOptions options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve
        };

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

            return Ok(JsonSerializer.Serialize(products, options));
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
        public IActionResult AddProducts(Product addProduct)
        {
            var product = new Product()
            {
                ProductCode = addProduct.ProductCode,
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

            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(int id, Product updateProduct)
        {
            var product = dbContext.Products.Find(id);

            if (product is null) return NotFound();

                product.ProductCode = updateProduct.ProductCode;
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
