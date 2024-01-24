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

    public class SalesQuotesDetailController : Controller
    {
        private readonly FretCloudDBContext _context;

        public SalesQuotesDetailController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("")]
        public async Task<IActionResult> GetQuatesList()
        {
            var salesquotenew = await _context.SalesQuoteDetailsNews.ToListAsync();
            return Ok(salesquotenew);
        }
        // [HttpGet("Detail/{id}")]
        // public async Task<IActionResult> GetQuatesListbyid(int id)
        // {
        //     var cc = _context.SalesQuoteDetailsNews.Where(x => x.SalesQuoteId == id).FirstOrDefault();
        //     return Ok(cc);
        // }
        [HttpGet("SalesQuoteId/{id}")]
        public async Task<IActionResult> GetQuatesDetail(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.SalesQuoteDetailsNews.Where(x => x.SalesQuoteId == id).ToListAsync();
            return Ok(cc);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuates(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.SalesQuoteDetailsNews.Where(x => x.SalesQuoteDetailId == id).ToListAsync();
            return Ok(cc);
        }
        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] SalesQuoteDetailsNew salesquotenew)
        {

            try
            {

                // Console.WriteLine(salesquotenew.CompanyName);

                Console.WriteLine("insert started");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _user = await _context.SalesQuoteDetailsNews.AsNoTracking().FirstOrDefaultAsync(u => u.SalesQuoteDetailId == salesquotenew.SalesQuoteDetailId);



                if (_user != null)
                {
                    Console.WriteLine(_user.SalesQuoteDetailId);
                    // int fbid = _user.UniqueId;
                    salesquotenew.SalesQuoteDetailId = _user.SalesQuoteDetailId;
                    _context.Entry(salesquotenew).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Sales Quates");
                    _context.SalesQuoteDetailsNews.Add(salesquotenew);
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
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] SalesQuoteDetailsNew salesquotenew)
        {
            Console.WriteLine("Update Sales Quates");

            if (id != salesquotenew.SalesQuoteDetailId)
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
            return _context.SalesQuoteDetailsNews.Any(e => e.SalesQuoteDetailId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesQuoteDetailNews(int id)
        {
            var salesquotenew = await _context.SalesQuoteDetailsNews.FindAsync(id);
            if (salesquotenew == null)
            {
                return NotFound();
            }

            _context.SalesQuoteDetailsNews.Remove(salesquotenew);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

