using Microsoft.AspNetCore.Mvc;
using pos_system.Data;
using pos_system.Models.Entities;
using System.Net;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public SupplierController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getSuppliers()
        {
            return Ok(dbContext.Supplier.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getSupplierById(int id)
        {
            var cat = dbContext.Supplier.Find(id);

            if (cat is null) return NotFound();

            return Ok(cat);
        }

        [HttpPost]
        public IActionResult AddSupplier(Supplier addSupplier)
        {
            var supplier = new Supplier()
            {
                SupplierCode = addSupplier.SupplierCode,
                SupplierName = addSupplier.SupplierName,
                ContactPerson = addSupplier.ContactPerson,
                Email = addSupplier.Email,
                Mobile1 = addSupplier.Mobile1,
                Mobile2 = addSupplier.Mobile2,
                Address = addSupplier.Address,
                CreditLimit = addSupplier.CreditLimit
            };

            dbContext.Supplier.Add(supplier);
            dbContext.SaveChanges();

            return Ok(supplier);
        }

        [HttpPut]
        public IActionResult UpdateSupplier(int id, Supplier updateSupplier)
        {
            var supplier = dbContext.Supplier.Find(id);

            if (supplier is null) return NotFound();

            supplier.SupplierCode = updateSupplier.SupplierCode;
            supplier.SupplierName = updateSupplier.SupplierName;
            supplier.ContactPerson = updateSupplier.ContactPerson;
            supplier.Email = updateSupplier.Email;
            supplier.Mobile1 = updateSupplier.Mobile1;
            supplier.Mobile2 = updateSupplier.Mobile2;
            supplier.Address = updateSupplier.Address;
            supplier.CreditLimit = updateSupplier.CreditLimit;

            dbContext.SaveChanges();
            return Ok(supplier);
        }

        [HttpDelete]
        public IActionResult DeleteSupplier(int id)
        {
            var supplier = dbContext.Supplier.Find(id);

            if (supplier is null) return NotFound();

            dbContext.Supplier.Remove(supplier);
            dbContext.SaveChanges();
            return Ok(supplier);
        }
    }
}
