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
    public class FactoryService : IFactoryService
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public FactoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FactoryDTO>> GetAllFactories()
        {
            var x = await _uow.Factories.GetAll();
            List<FactoryDTO> result = _mapper.Map<List<FactoryDTO>>(x);
            return result;

        }
        public async Task<PagedList<FactoryDTO>> GetItemPagesFiltered(FactoryParameters parameters)
        {
            var x = await _uow.Factories.GetAllPagesFiltered(parameters);
            var list = _mapper.Map<PagedList<FactoryDTO>>(x);
            return list;
        }
        public async Task<int> CountItems(FactoryParameters parameters)
        {

            return await _uow.Factories.CountItems(parameters);
        }
        public async Task<FactoryDTO> GetFactory(int id)
        {
            var x = await _uow.Factories.GetById(id);
            return _mapper.Map<Factory, FactoryDTO>(x);

        }
        public async Task<int> AddFactory(FactoryDTO factory)
        {
            var x = _mapper.Map<FactoryDTO, Factory>(factory);
            return await _uow.Factories.Add(x);
        }
        public async Task UpdateFactory(FactoryDTO factory)
        {
            var x = _mapper.Map<FactoryDTO, Factory>(factory);
            await _uow.Factories.Update(x);
        }
        public async Task DeleteFactory(int id)
        {
            await _uow.Factories.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
