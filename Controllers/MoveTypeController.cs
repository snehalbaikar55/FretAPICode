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

    public class MoveTypeController : Controller
    {
        private readonly FretCloudDBContext _context;

        public MoveTypeController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet()]
        public async Task<IActionResult> GetJobTypeMasters()
        {
            var MoveType = await _context.MoveTypes.Take(100).ToListAsync();
            return Ok(MoveType);
        }
        
    }
}