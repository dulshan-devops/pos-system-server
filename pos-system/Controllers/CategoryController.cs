using Microsoft.AspNetCore.Mvc;
using pos_system.Data;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getCategories()
        {
            return Ok(dbContext.Category.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getCategoryById(int id)
        {
            var cat = dbContext.Category.Find(id);

            if (cat is null) return NotFound();

            return Ok(cat);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategory addCategory)
        {
            var category = new Category()
            {
                Name = addCategory.Name,
                Desc = addCategory.Desc,
            };

            dbContext.Category.Add(category);
            dbContext.SaveChanges();

            return Ok(category);
        }

        [HttpPut]
        public IActionResult UpdateCategory(int id, UpdateCategory updateCategory)
        {
            var cat = dbContext.Category.Find(id);

            if (cat is null) return NotFound();

            cat.Name = updateCategory.Name;
            cat.Desc = updateCategory.Desc;

            dbContext.SaveChanges();
            return Ok(cat);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var category = dbContext.Category.Find(id);

            if (category is null) return NotFound();

            dbContext.Category.Remove(category);
            dbContext.SaveChanges();
            return Ok(category);
        }
    }
}
