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
    public class Order_Items_Service : IOrder_Items_Service
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public Order_Items_Service(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Order_Items_DTO>> GetAllOrd()
        {
            var x = await _uow.Order_Items.GetAll();
            List<Order_Items_DTO> result = new List<Order_Items_DTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Order_Items, Order_Items_DTO>(element));
            return result;

        }
        public async Task<Order_Items_DTO> GetOrd(int id)
        {
            var x = await _uow.Order_Items.GetById(id);
            return _mapper.Map<Order_Items, Order_Items_DTO>(x);

        }
        public async Task<int> AddOrd(Order_Items_DTO order_Items_)
        {
            var x = _mapper.Map<Order_Items_DTO, Order_Items>(order_Items_);
            return await _uow.Order_Items.Add(x);
        }
        public async Task UpdateOrd(Order_Items_DTO order_Items_)
        {
            var x = _mapper.Map<Order_Items_DTO, Order_Items>(order_Items_);
            await _uow.Order_Items.Update(x);
        }
        public async Task DeleteOrd(int id)
        {
            await _uow.Order_Items.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
