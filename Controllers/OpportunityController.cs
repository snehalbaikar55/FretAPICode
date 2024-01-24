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

    public class OpportunityController : Controller
    {
        private readonly FretCloudDBContext _context;

        public OpportunityController(FretCloudDBContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> GetOpportunity()
        {

            var Opportunity = await _context.Opportunities.Take(100).ToListAsync();
            return Ok(Opportunity);
            // var Opportunity = _context.Opportunities
            // .Where(x => x.OpportunityId > 319196 && x.JobNo.ToLower().StartsWith("mse"))
            // .ToList();

            // return Ok(Opportunity);
        }
     

      [HttpPost("Post")]
        public async Task<IActionResult> CreateCargo([FromBody] Opportunity Opportunity)
        {

            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            var _cargo = await _context.Opportunities.AsNoTracking().FirstOrDefaultAsync(u => u.OpportunityId == Opportunity.OpportunityId);

      

            if (_cargo != null)
            {
                Console.WriteLine(_cargo.OpportunityId);
                // int fbid = _user.UniqueId;
                Opportunity.OpportunityId = Opportunity.OpportunityId;
                _context.Entry(Opportunity).State = EntityState.Modified;

            }
            else
            {
                Console.WriteLine("Create New ");
                _context.Opportunities.Add(Opportunity);
            }


            await _context.SaveChangesAsync();

            return Ok(Opportunity);
        }

          [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOpportunity(int id, [FromBody] Opportunity opportunity)
        {
            Console.WriteLine("Update opportunities started");
            Console.WriteLine(opportunity.OpportunityName);
            if (id != opportunity.OpportunityId)
            {
                return BadRequest();
            }

            //    var compType = await _context.CompanyTypes.FirstOrDefaultAsync(ct => ct.CompanyTypeId == company.CompanyTypeId);
            //     company.CompanyType = compType;
            _context.Entry(opportunity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Console.WriteLine("Update Companies called");
                return Ok(opportunity);

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
            return _context.Cargos.Any(e => e.CargoId == id);
        }
        [HttpDelete("{id}")]
                public async Task<IActionResult> DeleteOpportunities(int id)
                {
                    var opportunity = await _context.Opportunities.FindAsync(id);
                    if (opportunity == null)
                    {
                        return NotFound();
                    }

                    _context.Opportunities.Remove(opportunity);
                    await _context.SaveChangesAsync();

                    return NoContent();
                }
    }
}
