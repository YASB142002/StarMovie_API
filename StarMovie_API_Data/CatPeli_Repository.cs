using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class CatPeli_Repository : ICatPeli
    {
        public Task<bool> DeleteCatPeliById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatgPeli>> GetAllCatPelis()
        {
            throw new NotImplementedException();
        }

        public Task<CatgPeli> GetCatPeliById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCatPeli(CatgPeli catgPeli)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCatPeli(CatgPeli cat)
        {
            throw new NotImplementedException();
        }
    }
}
