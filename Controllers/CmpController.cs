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

    public class CmpController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CmpController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("CompanyLi")]
        public async Task<IActionResult> GetCompanyList()
        {
            // var DemoCompany = await _context.Companies.ToListAsync();
            var DemoCompany = _context.Companies
            .Where(c => c.CompanyId > 196125)
            .ToList();

            return Ok(DemoCompany);
        }
        [HttpGet("Customer")]
        public async Task<IActionResult> GetCustomerList()
        {
            var cust = _context.Companies
            // .Where(c => c.CompanyType=='Customer')
            .Where(c => c.CompanyTypeId==5 )
            .ToList();

            return Ok(cust);
        }

         [HttpGet("check/{compname}")]
        public async Task<IActionResult> GetComp(string compname)
        {
            Console.WriteLine("start" + compname.ToString());
            // var cc = await _context.Companies.FirstOrDefaultAsync(x => x.CompanyName == compname);

            var cc = await _context.Companies.Where(x => x.CompanyName.Contains(compname)).ToListAsync();
            Console.WriteLine("User Exist",cc);
            return Ok(cc);
            
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.Companies.FirstOrDefaultAsync(x => x.CompanyId == id);
            return Ok(cc);
        }

       [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] Company company)
        {

            try
            {

                Console.WriteLine(company.CompanyName);

                Console.WriteLine("insert started");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _user = await _context.Companies.AsNoTracking().FirstOrDefaultAsync(u => u.CompanyId == company.CompanyId);


                if (_user != null)
                {
                    Console.WriteLine(_user.CompanyId);
                    // int fbid = _user.UniqueId;
                    company.CompanyId = _user.CompanyId;
                    _context.Entry(company).State = EntityState.Modified;

                }
               
                else
                {
                var compType = await _context.CompanyTypes.FirstOrDefaultAsync(ct => ct.CompanyTypeId == company.CompanyTypeId);
                company.CompanyType = compType;
                    Console.WriteLine("Create New Company");
                    _context.Companies.Add(company);
                }


                await _context.SaveChangesAsync();

                return Ok(company);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }
    
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] Company company)
        {
            Console.WriteLine("Update Companies started");
            Console.WriteLine(company.CompanyName);
            if (id != company.CompanyId)
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
            return _context.Companies.Any(e => e.CompanyId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanies(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("Carrier")]
            public async Task<IActionResult> GetCarrier()
            {
                var carrier = _context.Companies
                .Where(c => c.CompanyTypeId==17)
                .ToList();

                return Ok(carrier);
            }
}
}
