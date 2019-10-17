using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosesmt.Api.Repository
{
    public interface IGenericRepository<T>
    {
        IList<T> List(Func<T, bool> lambda = null);

        T Get(long id);

        T Get(Func<T, bool> lambda);

        void Create(T entity);

        void Edit(T entity);

        void Delete(long id);
    }
}
