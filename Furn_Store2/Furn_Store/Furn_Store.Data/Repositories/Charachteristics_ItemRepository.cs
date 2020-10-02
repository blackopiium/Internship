using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Data.EFCore
{
    public class Charachteristics_ItemRepository : GenericRepository<Charachteristics_Item, int>, ICharachteristics_ItemRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public Charachteristics_ItemRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
