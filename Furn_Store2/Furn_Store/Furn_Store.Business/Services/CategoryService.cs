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
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            var x = await _uow.Categories.GetAll();
            List<CategoryDTO> result = _mapper.Map<List<CategoryDTO>>(x);
            return result;

        }
        public async Task<CategoryDTO> GetCategory(int id)
        {
            var x = await _uow.Categories.GetById(id);
            return _mapper.Map<Category, CategoryDTO>(x);

        }
        public async Task<int> AddCategory(CategoryDTO category)
        {
            var x = _mapper.Map<CategoryDTO, Category>(category);
            return await _uow.Categories.Add(x);
        }
        public async Task UpdateCategory(CategoryDTO category)
        {
            var x = _mapper.Map<CategoryDTO, Category>(category);
            await _uow.Categories.Update(x);
        }
        public async Task DeleteCategory(int id)
        {
            await _uow.Categories.Remove(id);
        }
        public async Task<PagedList<CategoryDTO>> GetItemPagesFiltered(CategoryParameters parameters)
        {
            var x = await _uow.Categories.GetAllPagesFiltered(parameters);
            var list = _mapper.Map<PagedList<CategoryDTO>>(x);
            return list;
        }
        public async Task<int> CountItems(CategoryParameters parameters)
        {
            
            return await _uow.Categories.CountItems(parameters);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}