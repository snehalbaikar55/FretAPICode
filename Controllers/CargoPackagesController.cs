using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FretAPI.Model;

namespace FretCloudAPI.Controllers
{
    [Route("api/[controller]")]

    public class CargoPackagesController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoPackagesController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet("ContainerPackageList")]
            public async Task<IActionResult> GetCompanyList()
            {
                var DemoContainer = await _context.CargoPackages.Take(100).ToListAsync();
                return Ok(DemoContainer);
            }
        [HttpGet("GetPackageByCargoID")]
            public async Task<IActionResult> GetPackage(int id)
            {
                var myContainer = await _context.CargoPackages.Where(x => x.CargoId == id).ToListAsync();
                return Ok(myContainer);
            }

        [HttpPost("Post")]
            public async Task<IActionResult> CreateCargo([FromBody] CargoPackage CargoL)
            {

                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                var _cargo = await _context.CargoPackages.AsNoTracking().FirstOrDefaultAsync(u => u.CargoPackId == CargoL.CargoPackId);

        

                if (_cargo != null)
                {
                    Console.WriteLine(_cargo.CargoPackId);
                    // int fbid = _user.UniqueId;
                    CargoL.CargoPackId = _cargo.CargoPackId;
                    _context.Entry(CargoL).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Cargo");
                    _context.CargoPackages.Add(CargoL);
                }


                await _context.SaveChangesAsync();

                return Ok(CargoL);
            }
        
    }
}