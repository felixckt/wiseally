using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Azure_SQL_Web_API.Data;
using Microsoft.AspNetCore.Cors;
using ModelClass.Model;


namespace Azure_SQL_Web_API.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderHeadersController : ControllerBase
    {
        private readonly Azure_SQL_Web_APIContext _context;

        public SalesOrderHeadersController(Azure_SQL_Web_APIContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelClass.Model.SalesOrder>>> GetSalesOrderHeader()
        {
            return await _context.SalesOrder.ToListAsync();
        }

        // GET: api/SalesOrderHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelClass.Model.SalesOrder>> GetSalesOrderHeader(int id)
        {
            var salesOrderHeader = await _context.SalesOrder.FindAsync(id);

            if (salesOrderHeader == null)
            {
                return NotFound();
            }

            return salesOrderHeader;
        }

        // PUT: api/SalesOrderHeaders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderHeader(int id, ModelClass.Model.SalesOrder salesOrderHeader)
        {
            if (id != salesOrderHeader.SalesOrderID)
            {
                return BadRequest();
            }

            _context.Entry(salesOrderHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderHeaderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SalesOrderHeaders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SalesOrder>> PostSalesOrderHeader(ModelClass.Model.SalesOrder salesOrderHeader)
        {
            _context.SalesOrder.Add(salesOrderHeader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderHeader", new { id = salesOrderHeader.SalesOrderID }, salesOrderHeader);
        }

        // DELETE: api/SalesOrderHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ModelClass.Model.SalesOrder>> DeleteSalesOrderHeader(int id)
        {
            var salesOrderHeader = await _context.SalesOrder.FindAsync(id);
            if (salesOrderHeader == null)
            {
                return NotFound();
            }

            _context.SalesOrder.Remove(salesOrderHeader);
            await _context.SaveChangesAsync();

            return salesOrderHeader;
        }

        private bool SalesOrderHeaderExists(int id)
        {
            return _context.SalesOrder.Any(e => e.SalesOrderID == id);
        }
    }
}
