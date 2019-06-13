using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExitFeedback.Models.Contracts
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> Find();
        Task<IEnumerable<T>> FindWhere(Expression<Func<T, bool>> specification);
        Task<T> GetById(int id);
        Task<T> Update(T entity);
        Task<T> Create(T entity);
        Task<T> Delete(int id);
    }
}
