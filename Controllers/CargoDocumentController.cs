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

    public class CargoDocumentController : Controller
    {
        private readonly FretCloudDBContext _context;

        public CargoDocumentController (FretCloudDBContext context)
        {
            _context = context;
        }
        [HttpGet()]
        public async Task<IActionResult> GetCompanyList()
        {
           var DemoCompany = await _context.CargoDocuments.ToListAsync();
           
            return Ok(DemoCompany);
        }

        [HttpGet("GetDocumentByCargoID")]
            public async Task<IActionResult> GetDocument(int id)
            {
                var myDocument = await _context.CargoDocuments.Where(x => x.CargoId == id).ToListAsync();
                return Ok(myDocument);
            }


        [HttpGet("GetDocumentBycargoDocumentId")]
            public async Task<IActionResult> GetcargoDocument(int id)
            {
                var myDocument = await _context.CargoDocuments.Where(x => x.CargoDocumentId == id).ToListAsync();
                return Ok(myDocument);
            }


         [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargoDocuments(int id)
        {
            var Document = await _context.CargoDocuments.FindAsync(id);
            if (Document == null)
            {
                return NotFound();
            }

            _context.CargoDocuments.Remove(Document);
            await _context.SaveChangesAsync();

            return NoContent();
        }
      
       [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] CargoDocument contact)
        {

            try
            {

                Console.WriteLine(contact.CargoDocumentId);

                Console.WriteLine("insert started");

                // if (!ModelState.IsValid)
                //     return BadRequest("Invalid data.");

                var _user = await _context.CargoDocuments.AsNoTracking().FirstOrDefaultAsync(u => u.CargoDocumentId == contact.CargoDocumentId);



                if (_user != null)
                {
                    Console.WriteLine(_user.CargoDocumentId);
                    // int fbid = _user.UniqueId;
                    contact.CargoDocumentId = _user.CargoDocumentId;
                    _context.Entry(contact).State = EntityState.Modified;

                }
                else
                {
                    Console.WriteLine("Create New Company");
                    _context.CargoDocuments.Add(contact);
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
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] CargoDocument Contact)
        {
            Console.WriteLine("Update Contacts started");

            if (id != Contact.CargoDocumentId)
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
            return _context.CargoDocuments.Any(e => e.CargoDocumentId == id);
        }

        
        
    }
}