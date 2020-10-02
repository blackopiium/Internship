using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Data.EFCore
{
    public class Order_ItemsRepository : GenericRepository<Order_Items, int>, IOrder_Items_Repository
    {
        private readonly RepositoryContext _repositoryContext;
        public Order_ItemsRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
