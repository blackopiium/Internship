using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Interfaces
{
    public interface IRepository<T, TId> where T : class, IEntity<TId>
    {
        Task<T> GetById(TId id);
        Task<int> Add(T entity);
        Task Update(T entity);
        Task Remove(TId id);

        Task<IEnumerable<T>> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
