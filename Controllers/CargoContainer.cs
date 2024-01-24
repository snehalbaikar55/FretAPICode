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

    public class CargoContainerController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoContainerController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet("GetContainerByCargoID")]
            public async Task<IActionResult> GetContainer(int id)
            {
                var myContainer = await _context.CargoContainers.Where(x => x.CargoId == id).Take(100).ToListAsync();
                return Ok(myContainer);
            }

        [HttpGet("ContainerList")]
            public async Task<IActionResult> GetCompanyList()
            {
                var DemoContainer = await _context.CargoContainers.ToListAsync();
                return Ok(DemoContainer);
            }


        [HttpPost("Post")]
                public async Task<IActionResult> CreateUser([FromBody] CargoContainer company)
                {

                    try
                    {

                        // Console.WriteLine(company.CompanyName);

                        Console.WriteLine("insert started");

                        // if (!ModelState.IsValid)
                        //     return BadRequest("Invalid data.");

                        var _user = await _context.CargoContainers.AsNoTracking().FirstOrDefaultAsync(u => u.ContainerId == company.ContainerId);
                        var _cargo = await _context.Cargos.AsNoTracking().FirstOrDefaultAsync(u => u.CargoId == company.CargoId);
                        var _packageType = await _context.PackageTypes.AsNoTracking().FirstOrDefaultAsync(u => u.PackageTypeId == company.ContainerTypeId);   

                            //  Cargo c = new Cargo();
                            // c.CargoId = Convert.ToInt32(company.CargoId);

                            // PackageType pt = new PackageType();
                            // pt.PackageTypeId =  Convert.ToInt32(company.ContainerTypeId);

                        if (_user != null)
                        {
                            Console.WriteLine(_user.ContainerId);
                            // int fbid = _user.UniqueId;
                            company.ContainerId = _user.ContainerId;
                          

                            _context.Entry(company).State = EntityState.Modified;

                        }
                        else
                        {
                            Console.WriteLine("Create New Company");
                            company.Cargo = _cargo;
                            company.ContainerType = _packageType;
                            // _context.CargoContainers.Add(company);
                            _context.CargoContainers.Add(company);
                        }


                        await  _context.SaveChangesAsync();

                        return Ok(company);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return Ok(ex);
                    }
                }

        [HttpPut("{id}")]
                public async Task<IActionResult> UpdateCompany(int id, [FromBody] CargoContainer Contact)
                {
                    Console.WriteLine("Update Contacts started");

                    if (id != Contact.ContainerId)
                    {
                        return BadRequest();
                    }

                    _context.Entry(Contact).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                        Console.WriteLine("Update Container called");
                        return Ok(Contact);

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
                    return _context.CargoContainers.Any(e => e.ContainerId == id);
                }

    }
}