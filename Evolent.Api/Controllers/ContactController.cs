using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Evolent.Services;
using Evolent.Core.Models;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Evolent.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;


        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
               return Ok(await _contactService.GetAllContact());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            var contact = await _contactService.GetContactByID(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody]Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return await _contactService.AddContact(contact);

        }

        [HttpPut]
        public async Task<ActionResult<int>> Put([FromBody]Contact contact)
        {

            return Ok(await _contactService.UpdateContact(contact));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> Delete(int id)
        {
            var contact = _contactService.GetContactByID(id);

            if (contact == null)
            {
                return NotFound();
            }
            return Ok(await _contactService.DeleteContact(id));
        }
    }
}
