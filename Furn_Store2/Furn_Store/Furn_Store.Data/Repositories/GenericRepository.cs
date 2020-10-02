using Furn_Store.Data.Data.EFCore;
using Furn_Store.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Data
{
    public class GenericRepository<T, TId> : IRepository<T, TId> where T : class, IEntity<TId>
    {
        protected RepositoryContext _context;
        protected DbSet<T> _dbSet;
        public GenericRepository(RepositoryContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public async Task<int> Add(T entity)
        {

            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return 1;
        }
        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Remove(TId id)
        {
            T x = await _dbSet.FindAsync(id);
            _dbSet.Remove(x);
            await _context.SaveChangesAsync();

        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetById(TId id)
        {
            return await _dbSet.FindAsync(id);
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}