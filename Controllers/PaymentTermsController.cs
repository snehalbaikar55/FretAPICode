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

    public class PaymentTermsController : Controller
    {
        private readonly FretCloudDBContext _context;

        public PaymentTermsController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("Payment Terms")]
        public async Task<IActionResult> GetPaymentTerms()
        {
            var PaymentTerms = await _context.PaymentTerms.Take(100).ToListAsync();
            return Ok(PaymentTerms);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.PaymentTerms.FirstOrDefaultAsync(x => x.PaymentTermId == id);
            return Ok(cc);
        }
    }
}
