using System;
using System.Collections.Generic;
using System.Text;
using Evolent.Core.Models;
using Evolent.Core.Repositories;

namespace Evolent.Data.Repositories
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationContext context)
            : base(context)
        {

        }
    }
}
