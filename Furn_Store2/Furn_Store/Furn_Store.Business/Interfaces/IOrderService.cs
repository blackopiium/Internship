using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<OrderDTO> GetOrder(int id);
        Task UpdateOrder(OrderDTO order);
        Task<int> AddOrder(OrderDTO order);
        Task DeleteOrder(int id);
        void Dispose();
    }
}
