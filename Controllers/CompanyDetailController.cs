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

    public class CompanyDetailController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CompanyDetailController(FretCloudDBContext context)
        {
            _context = context;
        }

        // [HttpGet()]
        // public async Task<IActionResult> GetSingleCompany(int id)
        // {
        //     var company = await _context.CompanyDetails.FirstOrDefaultAsync(x => x.CompanyId == id);
        //     return Ok(company);
        // }
    [HttpGet()]
        public async Task<IActionResult> GetCompany()
        {
            // var CompanyType = await _context.VwCompanyDetails.ToListAsync();

  var CompanyType = _context.VwCompanyDetails
            .Where(c => c.CompanyId > 196125)
            .ToList();

            return Ok(CompanyType);
        }
        // [HttpGet("CompanyType")]
        // public async Task<IActionResult> GetCompanyTypes()
        // {
        //     var CompanyType = await _context.CompanyDetails.ToListAsync();
        //     return Ok(CompanyType);
        // }
        // [HttpGet("UserDisplayName")]
        // public async Task<IActionResult> GetUserDisplayName()
        // {
        //     var UserDisplayName = await _context.CompanyDetails.ToListAsync();
        //     return Ok(UserDisplayName);
        // }
        // [HttpGet("GstregType")]
        // public async Task<IActionResult> GetGstregType()
        // {
        //     var GstregType = await _context.CompanyDetails.ToListAsync();
        //     return Ok(GstregType);
        // }
        // [HttpGet("PaymentTerm")]
        // public async Task<IActionResult> GetPaymentTerm()
        // {
        //     var PaymentTerm = await _context.CompanyDetails.ToListAsync();
        //     return Ok(PaymentTerm);
        // }
    }
}