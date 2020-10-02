using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllClients();
        Task<ClientDTO> GetClient(int id);
        Task UpdateClient(ClientDTO client);
        Task<int> AddClient(ClientDTO client);
        Task DeleteClient(int id);
        void Dispose();
    }
}
