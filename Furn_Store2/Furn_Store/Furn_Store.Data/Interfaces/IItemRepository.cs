using Furn_Store.Data.Helpers;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Interfaces
{
    public interface IItemRepository : IRepository<Item, int>
    {
        public Task<PagedList<Item>> GetAllPagesFiltered(ItemParameters parameters);
        public Task<int> CountItems(ItemParameters parameters);
    }
}
