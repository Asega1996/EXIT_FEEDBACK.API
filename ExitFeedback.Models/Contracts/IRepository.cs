using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExitFeedback.Models.Contracts
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> specifications);
        Task<T> Get(int id);
        Task<T> Update(T entity);
        Task<T> Save(T entity);
        bool Delete(int id);
    }
}
