using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using FretCloudAPI.Model;
using FretAPI.Model;

namespace FretCloudAPI.Controllers
{
    [Route("api/[controller]")]

    public class InvoicesController : Controller
    {
        private readonly FretCloudDBContext _context;

        public InvoicesController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> GetInvoices()
        {
            var Invoice =  _context.Invoices
           .OrderByDescending(x => x.DateCreated)

            .Where(x => x.InvoiceDate.Year > 2022)
            .ToList();
            
            return Ok(Invoice);
        }
     
    
        [HttpGet("{id}")]
            public async Task<IActionResult> GetInvoiceId(int id)
            {
                Console.WriteLine("start" + id.ToString());

                var cc = await _context.VwInvoiceLists.FirstOrDefaultAsync(x => x.InvoiceId == id);
                return Ok(cc);
            }
            
        [HttpGet("GetInvoiceByCargoID")]
                    public async Task<IActionResult> GetInvoice(int id)
                    {
                        var Invoices = await _context.Invoices.Where(x => x.CargoId == id).ToListAsync();
                        return Ok(Invoices);
                    }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInvoice(int id, [FromBody] Invoice Contact)
        {
            Console.WriteLine("Update Invoices started");

            if (id != Contact.InvoiceId)
            {
                return BadRequest();
            }

            _context.Entry(Contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Invoices called");
                return Ok(Contact);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        private bool UserExists(int id)
        {
            return _context.Invoices.Any(e => e.InvoiceId == id);
        }

        
    }
}