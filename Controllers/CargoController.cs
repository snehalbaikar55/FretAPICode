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

    public class CargoController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoController (FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet("OceanExport")]
        public async Task<IActionResult> GetOECargoList()
        {
            // var CargoList = await _context.VwCargoNews.Where(x => x.JobNo.ToLower().StartsWith("mse")).ToListAsync();
            // return Ok(CargoList);
            var CargoList =await  _context.VwCargoNews
            .Where(x => x.CargoId > 319196 && (x.JobNo != null && x.JobNo.ToLower().StartsWith("mse")))
            .ToListAsync(); 

            return Ok(CargoList);
        }
        
         [HttpGet("OceanImport")]
        public async Task<IActionResult> GetOICargoList()
        {
            // var CargoList = await _context.VwCargoNews.Where(x => x.JobNo.ToLower().StartsWith("msi")).ToListAsync();
            // return Ok(CargoList);
            var CargoList =await  _context.VwCargoNews
            .Where(x => x.CargoId > 319192 && (x.JobNo != null && x.JobNo.ToLower().StartsWith("msi")))
            .ToListAsync();

            return Ok(CargoList);
        }
         [HttpGet("AirImport")]
        public async Task<IActionResult> GetAirImportCargoList()
        {
            // var CargoList = await _context.VwCargos.Where(x => x.JobNo.ToLower().StartsWith("mai")).ToListAsync();
            // return Ok(CargoList);
            var CargoList = await _context.VwCargoNews
            .Where(x => x.CargoId > 319135 &&(x.JobNo != null && x.JobNo.ToLower().StartsWith("mai")))
            .ToListAsync();

            return Ok(CargoList);
        }
         [HttpGet("AirExport")]
        public async Task<IActionResult> GetAirExportCargoList()
        {
           var CargoList = await _context.VwCargoNews
        .Where(x => x.CargoId > 319229 && (x.JobNo != null && x.JobNo.ToLower().StartsWith("mse")))
        .ToListAsync();

        return Ok(CargoList);

        }
      [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoId(int id)
        {
            Console.WriteLine("start" + id.ToString());

            var cc = await _context.VwCargoNews.FirstOrDefaultAsync(x => x.CargoId == id);
            return Ok(cc);
        }

      [HttpPost("Post")]
        public async Task<IActionResult> CreateCargo([FromBody] Cargo CargoL)
        {

            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            var _cargo = await _context.Cargos.AsNoTracking().FirstOrDefaultAsync(u => u.CargoId == CargoL.CargoId);

      

            if (_cargo != null)
            {
                Console.WriteLine(_cargo.CargoId);
                // int fbid = _user.UniqueId;
                CargoL.CargoId = _cargo.CargoId;
                _context.Entry(CargoL).State = EntityState.Modified;

            }
            else
            {
                Console.WriteLine("Create New Cargo");
                _context.Cargos.Add(CargoL);
            }


            await _context.SaveChangesAsync();

            return Ok(CargoL);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCargo(int id, [FromBody] Cargo cargo)
        {
            Console.WriteLine("Update Cargos started");
            Console.WriteLine(cargo.CargoNumber);
            if (id != cargo.CargoId)
            {
                return BadRequest();
            }

            //    var compType = await _context.CompanyTypes.FirstOrDefaultAsync(ct => ct.CompanyTypeId == company.CompanyTypeId);
            //     company.CompanyType = compType;
            _context.Entry(cargo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Companies called");
                return Ok(cargo);

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

            // return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Cargos.Any(e => e.CargoId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargos(int id)
        {
            var cargo = await _context.Cargos.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }

            _context.Cargos.Remove(cargo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

       
    }
}
