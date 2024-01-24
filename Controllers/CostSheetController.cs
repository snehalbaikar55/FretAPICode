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

    public class CostSheetController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CostSheetController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCostSheet()
            {
                var costSheet = await _context.CostSheets.Take(100).ToListAsync();
                return Ok(costSheet);
            }

        [HttpGet("GetCostSheettbyCargoID")]
        public async Task<IActionResult> GetCostSheets(int id)
            {
                var CostSheets = await _context.CostSheets.Where(x => x.CargoId == id).ToListAsync();
                return Ok(CostSheets);
            }
        [HttpGet("{id}")]
            public async Task<IActionResult> GetSingleCostSheets(int id)
            {
                var CostSheets = await _context.CostSheets.FirstOrDefaultAsync(x => x.CostSheetId == id);
                return Ok(CostSheets);
            }
               [HttpGet("{id}/{costsheetname}")]
            public async Task<IActionResult> GetSingleCostSheetsByidAndName(int id,string costsheetname)
            {
                var CostSheets = await _context.CostSheets.FirstOrDefaultAsync(x => x.CargoId == id && x.CostSheetType==costsheetname);
                return Ok(CostSheets);
            }
        [HttpPost()]
            public async Task<IActionResult> CreateUser([FromBody] CostSheet Cost)
            {

                try
                {

                    Console.WriteLine(Cost.CostSheetId);

                    Console.WriteLine("insert started");

                    // if (!ModelState.IsValid)
                    //     return BadRequest("Invalid data.");

                    // var _user = await _context.CostSheets.AsNoTracking().FirstOrDefaultAsync(u => u.CostSheetId == Cost.CostSheetId);
                    var _user = await _context.CostSheets.AsNoTracking().FirstOrDefaultAsync(u => u.CostSheetId == Cost.CostSheetId);



                    if (_user != null)
                    {
                        Console.WriteLine(_user.CostSheetId);
                        // int fbid = _user.UniqueId;
                        Cost.CostSheetId = _user.CostSheetId;
                        _context.Entry(Cost).State = EntityState.Modified;

                    }
                    else
                    {
                        Console.WriteLine("Create New Company");
                        _context.CostSheets.Add(Cost);
                    }


                    await _context.SaveChangesAsync();

                    return Ok(Cost);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return Ok(ex);
                }
            }
        [HttpPut("{id}")]
            public async Task<IActionResult> UpdateCostSheet(int id, [FromBody] CostSheet Cost)
            {
                Console.WriteLine("Update CostSheet started");

                if (id != Cost.CostSheetId)
                {
                    return BadRequest();
                }

                _context.Entry(Cost).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                    Console.WriteLine("Update CostSheet called");
                    return Ok(Cost);

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
                return _context.CostSheets.Any(e => e.CostSheetId == id);
            }

        [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCostSheets(int id)
            {
                var Cost = await _context.CostSheets.FindAsync(id);
                if (Cost == null)
                {
                    return NotFound();
                }

                _context.CostSheets.Remove(Cost);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        
        

    }
}