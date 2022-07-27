using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.IServices
{
    public interface IServices<T>
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Func<T, bool> predicate);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        void Delete(int Id);

    }
}
