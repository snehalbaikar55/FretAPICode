using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FretAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using FretCloudAPI.Model;

namespace FretCloudAPI.Controllers
{
    [Route("api/[controller]")]

    public class CargoStatusController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoStatusController(FretCloudDBContext context)
        {
            _context = context;
        }

     

        [HttpGet("")]
            public async Task<IActionResult> GetStatusList()
            {
                var DemoStatus = await _context.CargoStatuses.Take(100).ToListAsync();
                return Ok(DemoStatus);
            }
        [HttpGet("GetStatusByCargoID")]
            public async Task<IActionResult> GetStatus(int id)
            {
                var myStatus = await _context.CargoStatuses.Where(x => x.CargoId == id).ToListAsync();
                return Ok(myStatus);
            }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] CargoStatus status)
        {
            Console.WriteLine("Update CargoStatuses started");

            if (id != status.CargoStatusId)
            {
                return BadRequest();
            }

            _context.Entry(status).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update CargoStatuses called");
                return Ok(status);

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
            return _context.CargoStatuses.Any(e => e.CargoStatusId == id);
        }

    }
}