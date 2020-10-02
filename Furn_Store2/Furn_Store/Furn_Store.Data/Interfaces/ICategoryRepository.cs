using Furn_Store.Data.Helpers;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Interfaces
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        public Task<PagedList<Category>> GetAllPagesFiltered(CategoryParameters parameters);
        public Task<int> CountItems(CategoryParameters parameters);

    }
}
