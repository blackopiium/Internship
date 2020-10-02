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
    public class FactoryRepository : GenericRepository<Factory, int>, IFactoryRepository
    {
      /*  private readonly RepositoryContext _repositoryContext;*/
        public FactoryRepository(RepositoryContext context)
            : base(context)
        {
           /* _repositoryContext = context;*/
        }
        public async Task<PagedList<Factory>> GetAllPagesFiltered(FactoryParameters parameters)
        {
            return await PagedList<Factory>.ToPagedList(_dbSet, parameters.PageNumber, parameters.PageSize);

        }

        public async Task<int> CountItems(FactoryParameters parameters)
        {
            return await _context.Items.CountAsync();
        }
    }
}
