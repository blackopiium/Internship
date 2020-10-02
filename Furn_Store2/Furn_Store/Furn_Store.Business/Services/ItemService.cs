using AutoMapper;
using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using Furn_Store.Data.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Services
{
    public class ItemService : IItemService
    {
        IUnitOfWork _uow { get; set; }
        private IMapper _mapper;
        public ItemService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ItemDTO>> GetAllItems()
        {
            var x = await _uow.Items.GetAll();
            List<ItemDTO> result = _mapper.Map<List<ItemDTO>>(x);
            return result;
        }
        public async Task<ItemDTO> GetItem(int id)
        {
            var x = await _uow.Items.GetById(id);
            return _mapper.Map<Item, ItemDTO>(x);

        }
        public async Task<int> AddItem(ItemDTO item)
        {
            var x = _mapper.Map<ItemDTO, Item>(item);
            return await _uow.Items.Add(x);
        }
        public async Task UpdateItem(ItemDTO item)
        {
            var x = _mapper.Map<ItemDTO, Item>(item);
            await _uow.Items.Update(x);
        }
        public async Task DeleteItem(int id)
        {
            await _uow.Items.Remove(id);
        }
        public async Task<PagedList<ItemDTO>> GetItemPagesFiltered(ItemParameters parameters)
        {
            var x = await _uow.Items.GetAllPagesFiltered(parameters);
            var list = _mapper.Map<PagedList<ItemDTO>>(x);
            return list;
        }
        public async Task<int> CountItems(ItemParameters parameters)
        {
            if (parameters.Name != null)
                parameters.Name = parameters.Name.Trim().ToLower();
            return await _uow.Items.CountItems(parameters);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
