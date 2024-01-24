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

    public class CargoChargeController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoChargeController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
            public async Task<IActionResult> GetCargoCharge()
                {
                    var CargoCharge = await _context.CargoCharges.Take(100).ToListAsync();
                    return Ok(CargoCharge);
                }

        [HttpGet("GetCargoChargetbyCargoID")]
            public async Task<IActionResult> GetCargoCharges(int id)
                {
                    var CargoCharges = await _context.CargoCharges.Where(x => x.CargoId == id).ToListAsync();
                    return Ok(CargoCharges);
                }
        [HttpGet("GetCargoChargeByCostSheetID")]
            public async Task<IActionResult> GetCargoChargeByCostSheetID(int id)
                {
                    var CargoCharges = await _context.CargoCharges.Where(x => x.CostSheetId == id).ToListAsync();
                    return Ok(CargoCharges);
                }
          
         [HttpGet("GetCargoChargeByCostSheetIDandCargoID")]
            public async Task<IActionResult> GetCargoChargeByCostSheetIDandCargoID(int costsheetid,int cargoId)
                {
                    var CargoCharges = await _context.CargoCharges.Where(x => x.CostSheetId == costsheetid && x.CargoId ==cargoId).ToListAsync();
                    return Ok(CargoCharges);
                }
        [HttpGet("{id}")]
            public async Task<IActionResult> GetSingleCargoCharges(int id)
            {
                var CargoCharges = await _context.CargoCharges.FirstOrDefaultAsync(x => x.ChargeId == id);
                return Ok(CargoCharges);
            }
            // [HttpPost()]
            // public async Task<IActionResult> CreateUser([FromBody] CargoCharge Charge)
            // {

            //     try
            //     {

            //         Console.WriteLine(Charge.ChargeId);

            //         Console.WriteLine("insert started");

            //         // if (!ModelState.IsValid)
            //         //     return BadRequest("Invalid data.");

            //         var _user = await _context.CargoCharges.AsNoTracking().FirstOrDefaultAsync(u => u.ChargeId == Charge.ChargeId);



            //         if (_user != null)
            //         {
            //             Console.WriteLine(_user.ChargeId);
            //             // int fbid = _user.UniqueId;
            //             Charge.ChargeId = _user.ChargeId;
            //             _context.Entry(Charge).State = EntityState.Modified;

            //         }
            //         else
            //         {
            //             Console.WriteLine("Create New Company");
            //             _context.CargoCharges.Add(Charge);
            //         }


            //         await _context.SaveChangesAsync();

            //         return Ok(Charge);
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine(ex.Message);
            //         return Ok(ex);
            //     }
            // }
    
//             [HttpPost()]
//             public async Task<IActionResult> AddCargoCharges([FromBody] List<CargoCharge> charges)
// {
//     try
//     {
//         foreach (var charge in charges)
//         {
//             Console.WriteLine(charge.ChargeId);

//             try
//             {
//                 var existingCharge = await _context.CargoCharges.AsNoTracking()
//                     .FirstOrDefaultAsync(u => u.ChargeId == charge.ChargeId);

//                 if (existingCharge == null)
//                 {
//                     Console.WriteLine("Create New Company");
//                     _context.CargoCharges.Add(charge);
//                 }
//             }
//             catch (Exception innerEx)
//             {
//                 Console.WriteLine($"Error processing charge {charge.ChargeId}: {innerEx.Message}");
//                 throw; // Rethrow the exception to maintain the original 500 status code
//             }
//         }

//         await _context.SaveChangesAsync();

//         return Ok(charges);
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Outer Exception: {ex.Message}");
//         return StatusCode(500, "Internal Server Error");
//     }
// }

            [HttpPost("UpdateOrCreateCargoCharges")]
            public async Task<IActionResult> UpdateOrCreateCargoCharges([FromBody] List<CargoCharge> charges)
            {
                try
                {
                    foreach (var charge in charges)
                    {
                        Console.WriteLine(charge.ChargeId);

                        if (charge.ChargeId > 0)
                        {
                            // If ChargeId is greater than 0, it means the charge already exists, perform update logic
                            Console.WriteLine("Update Existing Charge");
                            var existingCharge = await _context.CargoCharges
                                .FirstOrDefaultAsync(u => u.ChargeId == charge.ChargeId);

                            if (existingCharge != null)
                            {
                                _context.Entry(existingCharge).CurrentValues.SetValues(charge);
                            }
                            else
                            {
                                Console.WriteLine($"Charge with ID {charge.ChargeId} not found for update");
                                // Handle the case where the charge doesn't exist
                            }
                        }
                        else
                        {
                            // If ChargeId is 0 or undefined, it means it's a new charge, perform add logic
                            Console.WriteLine("Create New Charge");
                            _context.CargoCharges.Add(charge);
                        }
                    }

                    await _context.SaveChangesAsync();

                    return Ok(charges);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return StatusCode(500, "Internal Server Error");
                }
            }


        [HttpPut("{id}")]
            public async Task<IActionResult> UpdateCargoCharge(int id, [FromBody] CargoCharge Charge)
            {
                Console.WriteLine("Update CargoCharge started");

                if (id != Charge.ChargeId)
                {
                    return BadRequest();
                }

                _context.Entry(Charge).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                    Console.WriteLine("Update CargoCharge called");
                    return Ok(Charge);

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
                return _context.CargoCharges.Any(e => e.ChargeId == id);
            }

        [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCargoCharges(int id)
            {
                var Charge = await _context.CargoCharges.FindAsync(id);
                if (Charge == null)
                {
                    return NotFound();
                }

                _context.CargoCharges.Remove(Charge);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        
        

    }
}