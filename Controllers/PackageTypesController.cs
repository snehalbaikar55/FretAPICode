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

    public class PackageTypeController : Controller
    {
        private readonly FretCloudDBContext _context;

        public PackageTypeController(FretCloudDBContext context)
        {
            _context = context;
        }
        [HttpGet("PackageTypes")]
            public async Task<IActionResult> GetCompanyList()
            {
                var PackageTypes = await _context.PackageTypes.Take(5).ToListAsync();
                return Ok(PackageTypes);
            }
        [HttpGet("Container")]
            public async Task<IActionResult> GetContainer()
            {
                var Packages = _context.PackageTypes
                .Where(c => c.PackageGroupId==1 )
                .ToList();

                return Ok(Packages);
            }
        [HttpGet("Packages")]
            public async Task<IActionResult> GetPackage()
            {
                var Packages = _context.PackageTypes
                .Where(c => c.PackageGroupId==2)
                .ToList();

                return Ok(Packages);
            }
    }
}