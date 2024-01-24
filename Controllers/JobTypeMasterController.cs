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

    public class JobTypeMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public JobTypeMasterController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet()]
        public async Task<IActionResult> GetJobTypeMasters()
        {
            var JobTypeMasters = await _context.JobTypeMasters.Take(100).ToListAsync();
            return Ok(JobTypeMasters);
        }
    }
}