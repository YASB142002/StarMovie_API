using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface ICatgPeliRepository
    {
        Task<IEnumerable<CatgPeli>> GetAllCatgPelis ();
        Task<CatgPeli> GetCatgPeli (string id);
        Task<bool> InsertCatgPeli (CatgPeli catgPeli);
        Task<bool> UpdateCatgPeli(string oldcatname, CatgPeli catgPeli);
        Task<bool> DeleteCatgPeli (string id);
    }
}
