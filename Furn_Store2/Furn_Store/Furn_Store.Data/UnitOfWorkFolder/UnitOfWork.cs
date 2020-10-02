using Furn_Store.Data.Data.EFCore;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.UnitOfWorkFolder
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _context;
        private readonly IItemRepository _item;
        private readonly ICategoryRepository _category;
        private readonly IFactoryRepository _factory;
        private readonly IClientRepository _client;
        private readonly ICharachteristics_ItemRepository _charach;
        private readonly IOrderRepository _orders;
        private readonly IOrder_Items_Repository _ord_it;
        private readonly UserManager<MyUser> _userManager;
        private readonly SignInManager<MyUser> _signInManager;
        private readonly RoleManager<MyRole> _roleManager;
        private readonly ISortHepler<Item> _itemSortHepler;
        public UnitOfWork(
            RepositoryContext context,
            IItemRepository item,
            ICategoryRepository category,
            IFactoryRepository factory,
            IClientRepository client,
            ICharachteristics_ItemRepository charach,
            IOrderRepository orders,
            IOrder_Items_Repository ord_it,
             UserManager<MyUser> userManager,
            SignInManager<MyUser> signInManager,
            RoleManager<MyRole> roleManager,
            ISortHepler<Item> itemSortHelper)
        {
            _context = context;
            _item = item;
            _category = category;
            _factory = factory;
            _client = client;
            _charach = charach;
            _orders = orders;
            _ord_it = ord_it;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _itemSortHepler = itemSortHelper;
        }
        public IItemRepository Items
        {
            get
            {
                return _item;
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                return _category;
            }
        }
        public IFactoryRepository Factories
        {
            get
            {
                return _factory;
            }
        }
        public IClientRepository Clients
        {
            get
            {
                return _client;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                return _orders;
            }
        }
        public IOrder_Items_Repository Order_Items
        {
            get
            {
                return _ord_it;
            }
        }
        public ICharachteristics_ItemRepository Charachteristics_Items
        {
            get
            {
                return _charach;
            }
        }
        public UserManager<MyUser> userManager
        {
            get
            {
                return _userManager;
            }
        }
        public RoleManager<MyRole> roleManager
        {
            get
            {
                return _roleManager;
            }
        }

        public SignInManager<MyUser> signInManager
        {
            get
            {
                return _signInManager;
            }
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
