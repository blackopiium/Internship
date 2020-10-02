using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Interfaces
{
    public interface IClientRepository : IRepository<Client, int>
    {
    }
}
