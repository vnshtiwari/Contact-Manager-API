using System;
using System.Collections.Generic;
using System.Text;
using Evolent.Core.Models;
using Evolent.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;
using Evolent.Core.Models;

namespace Evolent.Data.Repositories
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationContext context)
            : base(context)
        {





        }

        public async Task<IEnumerable<Contact>> ListAllActiveContact()
        {
            IEnumerable<Contact> contactList = await ListAllAsync();
            return  contactList.Where(c => c.Status == true);
        }

        public async Task<Contact> GetActiveContactById(int id)
        {
            Contact contact = await GetByIdAsync(id);

            if (contact != null)
            {
                if (contact.Status == true)
                    return contact;
                else
                    return null;

            }
            return null;
        }




    }
}
