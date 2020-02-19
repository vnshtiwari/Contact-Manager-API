using System;
using System.Collections.Generic;
using System.Text;
using Evolent.Core.Models;
using System.Threading.Tasks;

namespace Evolent.Core.Repositories
{
    public interface IContactRepository : IAsyncRepository<Contact>
    {
        Task<IEnumerable<Contact>> ListAllActiveContact();
        Task<Contact> GetActiveContactById(int id);

    }
}
