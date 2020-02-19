using System;
using System.Collections.Generic;
using System.Text;
using Evolent.Core.Models;
using System.Threading.Tasks;

namespace Evolent.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>>  GetAllContact();
        Task<Contact> GetContactByID(int ID);       
        Task<int> AddContact(Contact contact);
        Task<int> UpdateContact(Contact contact);
        Task<int> DeleteContact(int ID);

    }
}
