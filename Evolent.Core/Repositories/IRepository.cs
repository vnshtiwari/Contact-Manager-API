using System;
using System.Collections.Generic;
using System.Text;

namespace Evolent.Core.Repositories
{

    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
