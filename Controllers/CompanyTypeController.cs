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

    public class CompanyTypeController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CompanyTypeController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("CompanyTypeList")]
        public async Task<IActionResult> GetCompanyTypeList()
        {
            var DemoCompany = await _context.CompanyTypes.Take(100).ToListAsync();
            return Ok(DemoCompany);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.CompanyTypes.FirstOrDefaultAsync(x => x.CompanyTypeId == id);
            return Ok(cc);
        }

    }
}