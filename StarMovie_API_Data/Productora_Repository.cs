using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Productora_Repository : IProductora
    {
        public Task<bool> DeleteProductora(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductoraByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productora>> GetAllProductora()
        {
            throw new NotImplementedException();
        }

        public Task<Productora> GetProductoraById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Productora> GetProductoraByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProductora(Productora productora)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductora(Productora productora)
        {
            throw new NotImplementedException();
        }
    }
}
