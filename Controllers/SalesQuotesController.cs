using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using  FretAPI.Model;

namespace FretCloudAPI.Controllers
{
    [Route("api/[controller]")]

    public class SalesQuotesController : Controller
    {
        private readonly FretCloudDBContext _context;

        public SalesQuotesController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("")]
        public async Task<IActionResult> GetQuatesList()
        {
            
            var salesquotenew =await _context.SalesQuoteNews
            .Where(s => s.SalesQuoteId > 145730)
            .ToListAsync();
            return Ok(salesquotenew);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuates(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.SalesQuoteNews.FirstOrDefaultAsync(x => x.SalesQuoteId == id);
            return Ok(cc);
        }
        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] SalesQuoteNew salesquotenew)
        {

            try
            {

                // Console.WriteLine(salesquotenew.CompanyName);

                Console.WriteLine("insert started");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _user = await _context.SalesQuoteNews.AsNoTracking().FirstOrDefaultAsync(u => u.SalesQuoteId == salesquotenew.SalesQuoteId);



                if (_user != null)
                {
                    Console.WriteLine(_user.SalesQuoteId);
                    // int fbid = _user.UniqueId;
                    salesquotenew.SalesQuoteId = _user.SalesQuoteId;
                    _context.Entry(salesquotenew).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Sales Quates");
                    _context.SalesQuoteNews.Add(salesquotenew);
                }


                await _context.SaveChangesAsync();

                return Ok(salesquotenew);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] SalesQuoteNew salesquotenew)
        {
            Console.WriteLine("Update Sales Quates");

            if (id != salesquotenew.SalesQuoteId)
            {
                return BadRequest();
            }

            _context.Entry(salesquotenew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Sales Quates");
                return Ok(salesquotenew);

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
            return _context.SalesQuoteNews.Any(e => e.SalesQuoteId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesQuoteNews(int id)
        {
            var salesquotenew = await _context.SalesQuoteNews.FindAsync(id);
            if (salesquotenew == null)
            {
                return NotFound();
            }

            _context.SalesQuoteNews.Remove(salesquotenew);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

