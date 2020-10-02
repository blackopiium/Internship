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
    public class ClientService : IClientService
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public ClientService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ClientDTO>> GetAllClients()
        {
            var x = await _uow.Clients.GetAll();
            List<ClientDTO> result = new List<ClientDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Client, ClientDTO>(element));
            return result;

        }
        public async Task<ClientDTO> GetClient(int id)
        {
            var x = await _uow.Clients.GetById(id);
            return _mapper.Map<Client, ClientDTO>(x);

        }
        public async Task<int> AddClient(ClientDTO client)
        {
            var x = _mapper.Map<ClientDTO, Client>(client);
            return await _uow.Clients.Add(x);
        }
        public async Task UpdateClient(ClientDTO client)
        {
            var x = _mapper.Map<ClientDTO, Client>(client);
            await _uow.Clients.Update(x);
        }
        public async Task DeleteClient(int id)
        {
            await _uow.Clients.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
