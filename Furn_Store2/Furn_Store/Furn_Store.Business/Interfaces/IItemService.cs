using Furn_Store.Business.DTO;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task<ItemDTO> GetItem(int id);
        Task UpdateItem(ItemDTO item);
        Task<int> AddItem(ItemDTO item);
        Task DeleteItem(int id);
        Task<PagedList<ItemDTO>> GetItemPagesFiltered(ItemParameters parameters);
        Task<int> CountItems(ItemParameters parameters);
        void Dispose();
    }
}
