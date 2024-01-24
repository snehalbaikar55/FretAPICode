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

    public class CompanyAddressController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CompanyAddressController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet("CompanyAddressList")]
        public async Task<IActionResult> GetCompanyList()
        {
            var DemoCompany = await _context.CompanyAddresses.Take(5).ToListAsync();
            return Ok(DemoCompany);
        }


        [HttpGet("CompanyAddress")]
        public async Task<IActionResult> GetAddress()
        {
            var DemoCompany = await _context.VwDetailsAddresses.Take(100).ToListAsync();
            return Ok(DemoCompany);
        }


        [HttpGet("GetAddressByCmpID")]
        public async Task<IActionResult> GetMyAddress(int id)
        {
            var myaddress = await _context.CompanyAddresses.Where(x => x.CompanyId == id).ToListAsync();
            return Ok(myaddress);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.CompanyAddresses.FirstOrDefaultAsync(x => x.CompanyAddressId == id);
            return Ok(cc);
        }
        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] CompanyAddress companyAdd)
        {

            try
            {
                //  _context.CompanyAddresses.Add(companyAdd);
                Console.WriteLine("printing companyadd.id ");
                Console.WriteLine(companyAdd.ToString());
                Console.WriteLine(companyAdd.CompanyAddressId);

                Console.WriteLine("insert started");

                // if (!ModelState.IsValid)
                //     return BadRequest("Invalid data.");

                var _user = await _context.CompanyAddresses.AsNoTracking().FirstOrDefaultAsync(u => u.CompanyAddressId == companyAdd.CompanyAddressId);



                if (_user != null)
                {
                    Console.WriteLine(_user.CompanyAddressId);
                    // int fbid = _user.UniqueId;
                    companyAdd.CompanyAddressId = _user.CompanyAddressId;
                    _context.Entry(companyAdd).State = EntityState.Modified;

                }
                else
                {
                    // var compType = await _context.CompanyTypes.FirstOrDefaultAsync(ct => ct.CompanyTypeId == company.CompanyTypeId);
                    // company.CompanyType = compType;
                    Console.WriteLine("Create New Company");
                    _context.CompanyAddresses.Add(companyAdd);
                }


                await _context.SaveChangesAsync();

                return Ok(companyAdd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] CompanyAddress company)
        {
            Console.WriteLine("Update Companies started");
            // Console.WriteLine(company.CompanyName);
            if (id != company.CompanyAddressId)
            {
                return BadRequest();
            }

            //    var compType = await _context.CompanyTypes.FirstOrDefaultAsync(ct => ct.CompanyTypeId == company.CompanyTypeId);
            //     company.CompanyType = compType;
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
            return _context.CompanyAddresses.Any(e => e.CompanyAddressId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanies(int id)
        {
            var company = await _context.CompanyAddresses.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.CompanyAddresses.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
