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

    public class VendorBillController : Controller
    {
        private readonly FretCloudDBContext _context;

        public VendorBillController(FretCloudDBContext context)
        {
            _context = context;
        }

     

        [HttpGet("")]
            public async Task<IActionResult> GetCompanyList()
            {
                var DemoBill = await _context.VendorBills.Take(100).ToListAsync();
                return Ok(DemoBill);
            }
        [HttpGet("GetBillByCargoID")]
            public async Task<IActionResult> GetBill(int id)
            {
                var myBill = await _context.VendorBills.Where(x => x.CargoId == id).ToListAsync();
                return Ok(myBill);
            }
    }
}

