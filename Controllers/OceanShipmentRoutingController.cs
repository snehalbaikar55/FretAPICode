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

    public class OceanShipmentRoutingController : Controller
    {
        private readonly FretCloudDBContext _context;

        public OceanShipmentRoutingController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet("OceanShipmentRouting")]
                public async Task<IActionResult> GetContacts()
                {
                    var Contact = await _context.OceanShipmentRoutings.Take(100).ToListAsync();
                    return Ok(Contact);
                }
        [HttpGet("GetOceanShipmentRoutingsbyCargoId")]
                public async Task<IActionResult> GetMyOceanShipmentRouting(int id)
                {
                    var mycontacts = await _context.OceanShipmentRoutings.Where(x => x.ShipmentId == id).ToListAsync();
                    return Ok(mycontacts);
                }
      

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleContact(int id)
        {
            var contact = await _context.OceanShipmentRoutings.FirstOrDefaultAsync(x => x.OceanRoutingId == id);
            return Ok(contact);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] OceanShipmentRouting contact)
        {

            try
            {

                Console.WriteLine(contact.OceanRoutingId);

                Console.WriteLine("insert started");

                // if (!ModelState.IsValid)
                //     return BadRequest("Invalid data.");

                var _user = await _context.OceanShipmentRoutings.AsNoTracking().FirstOrDefaultAsync(u => u.OceanRoutingId == contact.OceanRoutingId);


                if (_user != null)
                {
                    Console.WriteLine(_user.OceanRoutingId);
                    // int fbid = _user.UniqueId;
                    contact.OceanRoutingId = _user.OceanRoutingId;
                    _context.Entry(contact).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Company");
                    _context.OceanShipmentRoutings.Add(contact);
                }


                await _context.SaveChangesAsync();

                return Ok(contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(ex);
            }
        }
        
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] OceanShipmentRouting Contact)
        {
            Console.WriteLine("Update Contacts started");

            if (id != Contact.OceanRoutingId)
            {
                return BadRequest();
            }

            _context.Entry(Contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Contacts called");
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
            return _context.OceanShipmentRoutings.Any(e => e.OceanRoutingId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContacts(int id)
        {
            var contact = await _context.OceanShipmentRoutings.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.OceanShipmentRoutings.Remove(contact);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}



