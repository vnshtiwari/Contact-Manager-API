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
            return await _contactRepository.ListAllActiveContact();
        }

        public async Task<Contact> GetContactByID(int ID)
        {
            return await _contactRepository.GetActiveContactById(ID);
        }

        public async Task<int> UpdateContact( Contact contact)
        {
            var con = await _contactRepository.GetActiveContactById(contact.ContactID);
            if (con != null)
            {
                return await _contactRepository.UpdateAsync(con);
            }
            return 0;
            //return await _contactRepository.UpdateAsync(contact);
        }

        public async Task<int> DeleteContact(int ID )
        {
            var contact=await _contactRepository.GetActiveContactById(ID);
            if (contact != null)
            {
                contact.Status = false;
                return await _contactRepository.UpdateAsync(contact);
            }
            return 0;
        }
    }
}
