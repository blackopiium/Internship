using Furn_Store.Business.DTO;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategories();
        Task<CategoryDTO> GetCategory(int id);
        Task UpdateCategory(CategoryDTO category);
        Task<int> AddCategory(CategoryDTO category);
        Task<PagedList<CategoryDTO>> GetItemPagesFiltered(CategoryParameters parameters);
        Task<int> CountItems(CategoryParameters parameters);
        Task DeleteCategory(int id);
        void Dispose();
    }
}
