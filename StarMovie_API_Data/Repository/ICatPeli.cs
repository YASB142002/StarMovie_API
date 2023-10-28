using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface ICatPeli
    {
        Task<IEnumerable<CatgPeli>> GetAllCatPelis();
        Task<CatgPeli> GetCatPeliById(int id);
        Task<bool> InsertCatPeli(CatgPeli catgPeli);
        Task<bool> UpdateCatPeli(CatgPeli cat);
        Task<bool> DeleteCatPeliById(int id);
    }
}
