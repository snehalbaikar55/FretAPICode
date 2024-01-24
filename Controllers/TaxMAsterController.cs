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

    public class TaxMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public TaxMasterController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
          public async Task<IActionResult> GetTax()
        {
          var Tax = await _context.TaxMasters.ToListAsync();
          return Ok(Tax);
        }
    }
}