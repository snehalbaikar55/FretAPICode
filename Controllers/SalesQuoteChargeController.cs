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

    public class SalesQuoteChargeController : Controller
    {
        private readonly FretCloudDBContext _context;

        public SalesQuoteChargeController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("")]
        public async Task<IActionResult> GetCompanyList()
        {
            var DemoCompany = await _context.SalesQuoteChargesNews.ToListAsync();
            return Ok(DemoCompany);
        }

        [HttpGet("{{salesDetailRowId}}")]
        public async Task<IActionResult> GetchargesList(int salesDetailRowId)
        {
            var DemoCompany = await _context.SalesQuoteChargesNews.Where(x => x.SqdetailRowId == salesDetailRowId).ToListAsync();
            return Ok(DemoCompany);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.SalesQuoteChargesNews.FirstOrDefaultAsync(x => x.SqchargeId == id);
            return Ok(cc);
        }
        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] SalesQuoteChargesNew company)
        {

            try
            {

                // Console.WriteLine(company.CompanyName);

                Console.WriteLine("insert started");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _user = await _context.SalesQuoteChargesNews.AsNoTracking().FirstOrDefaultAsync(u => u.SqchargeId == company.SqchargeId);



                if (_user != null)
                {
                    Console.WriteLine(_user.SqchargeId);
                    // int fbid = _user.UniqueId;
                    company.SqchargeId = _user.SqchargeId;
                    _context.Entry(company).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Company");
                    _context.SalesQuoteChargesNews.Add(company);
                }


                await  _context.SaveChangesAsync();

                return Ok(company);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] SalesQuoteChargesNew company)
        {
            Console.WriteLine("Update Companies started");

            if (id != company.SqchargeId)
            {
                return BadRequest();
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Companies called");
                return Ok(company);

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
            return _context.SalesQuoteChargesNews.Any(e => e.SqchargeId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanies(int id)
        {
            var company = await _context.SalesQuoteChargesNews.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.SalesQuoteChargesNews.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
        
        [HttpPost("UpdateOrCreateSalesQuoteCharges")]
        public async Task<IActionResult> UpdateOrCreateSalesQuoteCharges([FromBody] List<SalesQuoteChargesNew> salesQuoteCharges)
        {
            try
            {
                foreach (var charge in salesQuoteCharges)
                {
                    if (charge.SqchargeId > 0)
                    {
                        // Update logic
                        var existingCharge = await _context.SalesQuoteChargesNews
                            .FirstOrDefaultAsync(u => u.SqchargeId == charge.SqchargeId);

                        if (existingCharge != null)
                        {
                            _context.Entry(existingCharge).CurrentValues.SetValues(charge);
                        }
                        else
                        {
                            // Handle the case where the charge doesn't exist
                        }
                    }
                    else
                    {
                        // Add logic
                        _context.SalesQuoteChargesNews.Add(charge);
                    }
                }

                await _context.SaveChangesAsync();
                return Ok(salesQuoteCharges);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

    }
}

