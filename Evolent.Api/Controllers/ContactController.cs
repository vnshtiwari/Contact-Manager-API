using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Evolent.Services;
using Evolent.Core.Models;
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
        public async Task<IEnumerable<Contact>> Get()
        {
            return await _contactService.GetAllContact();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<Contact> Get(int id)
        {
            return await _contactService.GetContactByID(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<int> Post([FromBody]Contact contact)
        {
            return await _contactService.AddContact(contact);

        }

        [HttpPut]
        public async Task<int> Put([FromBody]Contact contact)
        {
            return await _contactService.UpdateContact(contact);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _contactService.DeleteContact(id);
        }
    }
}
