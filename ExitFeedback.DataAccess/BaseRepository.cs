using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExitFeedback.DataAccess
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ExitFeedbackDataContext _dbContext;

        public BaseRepository(ExitFeedbackDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> specification)
        {

            var result = _dbContext.Set<T>().Where(specification);
            return await result.ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Save(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
