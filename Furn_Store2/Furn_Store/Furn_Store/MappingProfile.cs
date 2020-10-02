using AutoMapper;
using Furn_Store.Business.DTO;
using Furn_Store.Business.DTO.Identity;
using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Item, ItemDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Factory, FactoryDTO>().ReverseMap();
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order_Items, Order_Items_DTO>().ReverseMap();
            CreateMap<Charachteristics_Item, Charachteristic_Item_DTO>().ReverseMap();
            CreateMap<MyRole, MyRoleDTO>().ReverseMap();

        }
    }
}
