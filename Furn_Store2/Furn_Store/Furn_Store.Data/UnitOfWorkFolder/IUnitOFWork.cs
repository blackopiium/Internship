using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.UnitOfWorkFolder
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; }
        ICategoryRepository Categories { get; }
        IFactoryRepository Factories { get; }
        IClientRepository Clients { get; }
        IOrderRepository Orders { get; }
        ICharachteristics_ItemRepository Charachteristics_Items { get; }
        IOrder_Items_Repository Order_Items { get; }
        UserManager<MyUser> userManager { get; }
        RoleManager<MyRole> roleManager { get; }
        SignInManager<MyUser> signInManager { get; }
        void Save();

    }
}
