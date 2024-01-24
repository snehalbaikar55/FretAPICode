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

    public class CountryStateMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CountryStateMasterController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
          public async Task<IActionResult> GetMyCountryState()
        {
          var Country = await _context.CountryStateMasters.Take(100).ToListAsync();
          return Ok(Country);
        }
    }
}