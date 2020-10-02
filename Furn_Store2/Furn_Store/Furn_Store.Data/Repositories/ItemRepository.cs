using Furn_Store.Data.Helpers;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

namespace Furn_Store.Data.Data.EFCore
{
    public class ItemRepository : GenericRepository<Item, int>, IItemRepository

    {
        private readonly ISortHepler<Item> _sortHelper;
        public ItemRepository(RepositoryContext context, ISortHepler<Item> sortHelper)
             : base(context)
        {
            _sortHelper = sortHelper;
        }
        public async Task<PagedList<Item>> GetAllPagesFiltered(ItemParameters parameters)
        {
            var items = FindByCondition(x => x.Price >= parameters.MinPrice && x.Price <= parameters.MaxPrice);
            SearchByName(ref items, parameters.Name);
            items = _sortHelper.ApplySort(items, parameters);
            return await PagedList<Item>.ToPagedList(items, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<int> CountItems(ItemParameters parameters)
        {
            return await _context.Items.CountAsync(x =>
               (x.Name.Contains(parameters.Name) || string.IsNullOrWhiteSpace(parameters.Name))
               && x.Price <= parameters.MaxPrice
               && x.Price >= parameters.MinPrice);
        }
        private void SearchByName(ref IQueryable<Item> items, string name)
        {
            if (!items.Any() || string.IsNullOrWhiteSpace(name))
                return;

            items = items.Where(x => x.Name.ToLower().Contains(name.Trim().ToLower()));
        }
    }
}