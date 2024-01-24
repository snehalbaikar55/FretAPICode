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

    public class AirLineMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public AirLineMasterController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("")]
        public async Task<IActionResult> GetOceanLineList()
        {
            var location = await _context.AirlineMasters.ToListAsync();
            
            return Ok(location);
        }

//         [HttpGet("{id}")]
//         public async Task<IActionResult> GetCompany(int id)
//         {
//             Console.WriteLine("start" + id.ToString());

//             var cc = await _context.DemoCompanies.FirstOrDefaultAsync(x => x.CompanyId == id);
//             return Ok(cc);
//         }
         [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] AirlineMaster ocean)
        {

            try
            {

                // Console.WriteLine(ocean.lineCompanyName);

                Console.WriteLine("insert started");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _user = await _context.AirlineMasters.AsNoTracking().FirstOrDefaultAsync(u => u.AirlineId == ocean.AirlineId);



                if (_user != null)
                {
                    Console.WriteLine(_user.AirlineId);
                    // int fbid = _user.UniqueId;
                    ocean.AirlineId = _user.AirlineId;
                    _context.Entry(ocean).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Company");
                    _context.AirlineMasters.Add(ocean);
                }


                await _context.SaveChangesAsync();

                return Ok(ocean);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }
//         [HttpPut("{id}")]
//         public async Task<IActionResult> UpdateCompany(int id, [FromBody] DemoCompany company)
//         {
//             Console.WriteLine("Update Companies started");

//             if (id != company.CompanyId)
//             {
//                 return BadRequest();
//             }

//             _context.Entry(company).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//                 Console.WriteLine("Update Companies called");
//                 return Ok(company);

//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!UserExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         private bool UserExists(int id)
//         {
//             return _context.DemoCompanies.Any(e => e.CompanyId == id);
//         }

//         [HttpDelete("{id}")]
//         public async Task<IActionResult> DeleteCompanies(int id)
//         {
//             var company = await _context.DemoCompanies.FindAsync(id);
//             if (company == null)
//             {
//                 return NotFound();
//             }

//             _context.DemoCompanies.Remove(company);
//             await _context.SaveChangesAsync();

//             return NoContent();
//         }
    }
}

