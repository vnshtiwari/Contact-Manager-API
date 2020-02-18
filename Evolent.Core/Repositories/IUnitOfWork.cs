using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evolent.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository Contacts { get; }
        Task<int> CommitAsync();
    }
}
