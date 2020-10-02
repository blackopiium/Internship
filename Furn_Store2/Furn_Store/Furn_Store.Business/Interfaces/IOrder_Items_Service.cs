using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IOrder_Items_Service
    {
        Task<IEnumerable<Order_Items_DTO>> GetAllOrd();
        Task<Order_Items_DTO> GetOrd(int id);
        Task UpdateOrd(Order_Items_DTO order_Items);
        Task<int> AddOrd(Order_Items_DTO order_Items);
        Task DeleteOrd(int id);
        void Dispose();
    }
}
