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

    public class CounryController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CounryController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
          public async Task<IActionResult> GetMyCountry()
        {
          var Country = await _context.CountryMasters.Take(100).ToListAsync();
          return Ok(Country);
        }
    }
}