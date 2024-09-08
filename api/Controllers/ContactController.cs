using api.Context;
using api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context) { 
        
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Contact([FromBody] ContactClass contact) {
            if (contact == null || string.IsNullOrWhiteSpace(contact.Name) || string.IsNullOrWhiteSpace(contact.Email) || string.IsNullOrWhiteSpace(contact.Message)) { 
                return BadRequest("Name, Email, Messaage is required");
            
            }
            _context.contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Message Sent successfully");
        }
    }
}
