using ExitFeedback.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExitFeedback.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> Create(T entity)
        {
            return _repository.Save(entity);
        }


        public virtual Task<T> GetById(int id)
        {
            return _repository.Get(id);
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> Find()
        {
            return _repository.Get();
        }

        public virtual Task<IEnumerable<T>> FindWhere(System.Linq.Expressions.Expression<Func<T, bool>> specification)
        {
            return _repository.Get(specifications: specification);
        }

        public virtual Task<T> Update(T entity)
        {
            return _repository.Update(entity);
            
        }
    }
}
