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

    public class ContactsController : Controller
    {
        private readonly FretCloudDBContext _context;

        public ContactsController(FretCloudDBContext context)
        {
            _context = context;
        }
 
       [HttpGet("Contact")]
        public async Task<IActionResult> GetContacts()
        {
            var Contact = await _context.Contacts.Take(100).ToListAsync();
            return Ok(Contact);
        }

        [HttpGet("GetContactbyCmpID")]
        public async Task<IActionResult> GetMyContacts(int id)
        {
            var mycontacts = await _context.Contacts.Where(x => x.CompanyId == id).ToListAsync();
            return Ok(mycontacts);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleContact(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.ContactId == id);
            return Ok(contact);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] Contact contact)
        {

            try
            {

                Console.WriteLine(contact.FirstName);

                Console.WriteLine("insert started");

                // if (!ModelState.IsValid)
                //     return BadRequest("Invalid data.");

                var _user = await _context.Contacts.AsNoTracking().FirstOrDefaultAsync(u => u.ContactId == contact.ContactId);



                if (_user != null)
                {
                    Console.WriteLine(_user.ContactId);
                    // int fbid = _user.UniqueId;
                    contact.ContactId = _user.ContactId;
                    _context.Entry(contact).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Company");
                    _context.Contacts.Add(contact);
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
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] Contact Contact)
        {
            Console.WriteLine("Update Contacts started");

            if (id != Contact.ContactId)
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
            return _context.Contacts.Any(e => e.ContactId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContacts(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    
    }
}

