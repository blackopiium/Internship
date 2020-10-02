using AutoMapper;
using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Furn_Store.Data.Models;
using Furn_Store.Data.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var x = await _uow.Orders.GetAll();
            List<OrderDTO> result = new List<OrderDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Order, OrderDTO>(element));
            return result;

        }
        public async Task<OrderDTO> GetOrder(int id)
        {
            var x = await _uow.Orders.GetById(id);
            return _mapper.Map<Order, OrderDTO>(x);

        }
        public async Task<int> AddOrder(OrderDTO order)
        {
            var x = _mapper.Map<OrderDTO, Order>(order);
            return await _uow.Orders.Add(x);
        }
        public async Task UpdateOrder(OrderDTO order)
        {
            var x = _mapper.Map<OrderDTO, Order>(order);
            await _uow.Orders.Update(x);
        }
        public async Task DeleteOrder(int id)
        {
            await _uow.Orders.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }

    }
}
