using Microsoft.AspNetCore.Mvc;
using pos_system.Data;
using pos_system.Models.Entities;

namespace pos_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TransactionTypeController : ControllerBase
    {
        public readonly ApplicationDbContext dbContext;

        public TransactionTypeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getTransactionTypes()
        {
            try
            {
                var transactionTypes = dbContext.TransactionType.ToList();
                return Ok(transactionTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddTransactionType(TransactionType addTransactionType)
        {
            try
            {
                var transactionType = new TransactionType
                {
                    TransactionTypeName = addTransactionType.TransactionTypeName,
                    Desc = addTransactionType.Desc
                };

                dbContext.TransactionType.Add(transactionType);
                dbContext.SaveChanges();
                return Ok(transactionType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateTransactionType(int id, TransactionType updateTransactionType)
        {
            try
            {
                var transactionType = dbContext.TransactionType.Find(id);
                if (transactionType is null) return NotFound("TransactionType not found");
                transactionType.TransactionTypeName = updateTransactionType.TransactionTypeName;
                transactionType.Desc = updateTransactionType.Desc;
                dbContext.SaveChanges();
                return Ok(transactionType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getTransactionTypeById(int id)
        {
            try
            {
                var transactionType = dbContext.TransactionType.Find(id);
                if (transactionType is null) return NotFound("TransactionType not found");
                return Ok(transactionType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}