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
    public class CharachteristicsService : ICharachteristics_Service
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public CharachteristicsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Charachteristic_Item_DTO>> GetAllCharc()
        {
            var x = await _uow.Charachteristics_Items.GetAll();
            List<Charachteristic_Item_DTO> result = _mapper.Map<List<Charachteristic_Item_DTO>>(x);
            return result;

        }
        public async Task<Charachteristic_Item_DTO> GetCharc(int id)
        {
            var x = await _uow.Charachteristics_Items.GetById(id);
            return _mapper.Map<Charachteristics_Item, Charachteristic_Item_DTO>(x);

        }
        public async Task<int> AddCharc(Charachteristic_Item_DTO charachteristics_Item)
        {
            var x = _mapper.Map<Charachteristic_Item_DTO, Charachteristics_Item>(charachteristics_Item);
            return await _uow.Charachteristics_Items.Add(x);
        }
        public async Task UpdateCharc(Charachteristic_Item_DTO charachteristic_Item_)
        {
            var x = _mapper.Map<Charachteristic_Item_DTO, Charachteristics_Item>(charachteristic_Item_);
            await _uow.Charachteristics_Items.Update(x);
        }
        public async Task DeleteCharc(int id)
        {
            await _uow.Charachteristics_Items.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}