using Furn_Store.Business.DTO;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IFactoryService
    {
        Task<IEnumerable<FactoryDTO>> GetAllFactories();
        Task<FactoryDTO> GetFactory(int id);
        Task UpdateFactory(FactoryDTO factory);
        Task<int> AddFactory(FactoryDTO factory);
        Task<PagedList<FactoryDTO>> GetItemPagesFiltered(FactoryParameters parameters);
        Task<int> CountItems(FactoryParameters parameters);
        Task DeleteFactory(int id);
        void Dispose();
    }
}
