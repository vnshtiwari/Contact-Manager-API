using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evolent.Core.Models;
using Evolent.Core.Repositories;

namespace Evolent.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<int> AddContact(Contact contact)
        {
            return await _contactRepository.AddAsync(contact);
        }      

        public async Task<IEnumerable<Contact>> GetAllContact()
        {
            return await _contactRepository.ListAllAsync();
        }

        public async Task<Contact> GetContactByID(int ID)
        {
            return await _contactRepository.GetByIdAsync(ID);
        }

        public async Task<int> UpdateContact( Contact contact)
        {
            return await _contactRepository.UpdateAsync(contact);
        }

        public async Task<int> DeleteContact(int ID )
        {
            var contact=await _contactRepository.GetByIdAsync(ID);
            contact.Status = false;
            return await _contactRepository.UpdateAsync(contact);
        }
    }
}
