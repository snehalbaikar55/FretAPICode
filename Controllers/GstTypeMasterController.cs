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

    public class GstTypeMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public GstTypeMasterController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet()]
        public async Task<IActionResult> GetGSTMasters()
        {
            var GSTMasters = await _context.GstTypeMasters.Take(100).ToListAsync();
            return Ok(GSTMasters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGST(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.GstTypeMasters.FirstOrDefaultAsync(x => x.GsttypeId == id);
            return Ok(cc);
        }
    }
}
