using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using  FretAPI.Model;

namespace FretCloudAPI.Controllers
{
    [Route("api/[controller]")]

    public class UserMasterController : Controller
    {
        private readonly FretCloudDBContext _context;

        public UserMasterController(FretCloudDBContext context)
        {
            _context = context;
        }
 
        [HttpGet("")]
        public async Task<IActionResult> GetUserList()
        {
            var usermaster = await _context.UserMasters.ToListAsync();
            return Ok(usermaster);
        }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetCompany(int id)
        // {
        //     Console.WriteLine("start" + id.ToString());

        //     var cc = await _context.UserMasters.FirstOrDefaultAsync(x => x.UserId == id);
        //     return Ok(cc);
        // }
        // [HttpPost()]
        // public async Task<IActionResult> CreateUser([FromBody] UserMaster usermaster)
        // {

        //     try
        //     {

        //         // Console.WriteLine(salesquotenew.CompanyName);

        //         Console.WriteLine("insert started");

        //         if (!ModelState.IsValid)
        //             return BadRequest("Invalid data.");

        //         var _user = await _context.UserMasters.AsNoTracking().FirstOrDefaultAsync(u => u.UserId == usermaster.UserId);



        //         if (_user != null)
        //         {
        //             Console.WriteLine(_user.UserId);
        //             // int fbid = _user.UniqueId;
        //             usermaster.UserId = _user.UserId;
        //             _context.Entry(usermaster).State = EntityState.Modified;

        //         }
        //         else
        //         {
        //             Console.WriteLine("Create New Sales Quates");
        //             _context.UserMasters.Add(usermaster);
        //         }


        //         await _context.SaveChangesAsync();

        //         return Ok(usermaster);
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         return Ok(ex);
        //     }
        // }
        // [HttpPut("{id}")]
        // public async Task<IActionResult> UpdateCompany(int id, [FromBody] UserMaster usermaster)
        // {
        //     Console.WriteLine("Update Sales Quates");

        //     if (id != usermaster.UserId)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(usermaster).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //         Console.WriteLine("Update Sales Quates");
        //         return Ok(usermaster);

        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!UserExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // private bool UserExists(int id)
        // {
        //     return _context.UserMasters.Any(e => e.UserId == id);
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteUserMasters(int id)
        // {
        //     var usermaster = await _context.UserMasters.FindAsync(id);
        //     if (usermaster == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.UserMasters.Remove(usermaster);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }
    }
}

