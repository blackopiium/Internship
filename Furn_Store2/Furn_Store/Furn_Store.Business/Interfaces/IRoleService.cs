using Furn_Store.Business.DTO.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IRoleService
    {
        Task CreateRole(MyRoleDTO role);
        Task AppointRole(string id, string role);
        Task<IList<string>> GetAllRolesByUserId(string id);
    }
}
