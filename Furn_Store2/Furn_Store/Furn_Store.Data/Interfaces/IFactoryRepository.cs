using Furn_Store.Data.Helpers;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Interfaces
{
    public interface IFactoryRepository : IRepository<Factory, int>
    {
        public Task<PagedList<Factory>> GetAllPagesFiltered(FactoryParameters parameters);
        public Task<int> CountItems(FactoryParameters parameters);

    }
}
