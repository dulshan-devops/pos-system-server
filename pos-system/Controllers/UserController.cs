using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pos_system.Data;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getUsers()
        {
            return Ok(dbContext.Users.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getUserById(int id)
        {
            var user = dbContext.Users.Find(id);

            if (user is null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUsers(User addUser)
        {
            var user = new User()
            {
                UserName = addUser.UserName,
                Email = addUser.Email,
                Password = addUser.Password,
                Role = addUser.Role,
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return Ok(user);
        }

        [HttpPut]
        public IActionResult UpdateUser(int id, User updateUser)
        {
            var user = dbContext.Users.Find(id);

            if (user is null) return NotFound();

            user.UserName = updateUser.UserName;
            user.Email = updateUser.Email;
            user.Password = updateUser.Password;
            user.Role = updateUser.Role;

            dbContext.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var user = dbContext.Users.Find(id);

            if (user is null) return NotFound();
            
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
            return Ok(user);
        }
    }
}
