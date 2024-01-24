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

    public class CounterMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CounterMasterController (FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> GetList()
        {
            var CounterList = _context.CounterMasters.Where(x => x.CounterId == 243).ToList(); 
            return Ok(CounterList);
        }


        [HttpGet("{id}")]
            public async Task<IActionResult> GetCounterId(int id)
            {
                Console.WriteLine("start" + id.ToString());

                var cc = await _context.CounterMasters.FirstOrDefaultAsync(x => x.CounterId == id);
                return Ok(cc);
            }
            

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] CounterMaster Counter)
        {
            Console.WriteLine("Update CounterMasters started");

            if (id != Counter.CounterId)
            {
                return BadRequest();
            }

            _context.Entry(Counter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update CounterMasters called");
                return Ok(Counter);

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
            return _context.CounterMasters.Any(e => e.CounterId == id);
        }

        
        
    }
}