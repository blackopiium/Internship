using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Data.EFCore
{
    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public OrderRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
