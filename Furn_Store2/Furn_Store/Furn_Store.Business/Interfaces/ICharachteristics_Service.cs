using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface ICharachteristics_Service
    {
        Task<IEnumerable<Charachteristic_Item_DTO>> GetAllCharc();
        Task<Charachteristic_Item_DTO> GetCharc(int id);
        Task UpdateCharc(Charachteristic_Item_DTO charc);
        Task<int> AddCharc(Charachteristic_Item_DTO charc);
        Task DeleteCharc(int id);
        void Dispose();
    }
}
