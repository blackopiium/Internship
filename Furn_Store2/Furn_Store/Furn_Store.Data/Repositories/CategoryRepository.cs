using Furn_Store.Data.Helpers;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Data.EFCore
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        /*private readonly RepositoryContext _repositoryContext;*/
        private readonly ISortHepler<Category>_sortHelper;
        public CategoryRepository(RepositoryContext context)
            : base(context)
        {
            /*_sortHelper = sortHelper;*/
            /* _repositoryContext = context;*/

        }
        public async Task<PagedList<Category>> GetAllPagesFiltered(CategoryParameters parameters)
        {
            return await PagedList<Category>.ToPagedList(_dbSet, parameters.PageNumber, parameters.PageSize);

        }

        public async Task<int> CountItems(CategoryParameters parameters)
        {
            return await _context.Items.CountAsync();
        }
    }
}
