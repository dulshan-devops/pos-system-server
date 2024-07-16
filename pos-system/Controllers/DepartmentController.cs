using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pos_system.Data;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public DepartmentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getDepartments()
        {
            return Ok(dbContext.Department.ToList());
        }

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            var dep = new Department()
            {
                DepartmentName = department.DepartmentName,
                Desc = department.Desc
            };

            dbContext.Department.Add(dep);
            dbContext.SaveChanges();

            return Ok(dep);
        }

        [HttpPut]
        public IActionResult UpdateDepartment(int id, Department updateDep)
        {
            var dep = dbContext.Department.Find(id);

            if (dep is null) return NotFound();

            dep.DepartmentName = updateDep.DepartmentName;
            dep.Desc = updateDep.Desc;

            dbContext.SaveChanges();
            return Ok(dep);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var dep = dbContext.Department.Find(id);

            if (dep is null) return NotFound();

            dbContext.Department.Remove(dep);
            dbContext.SaveChanges();
            return Ok(dep);
        }
    }
}
