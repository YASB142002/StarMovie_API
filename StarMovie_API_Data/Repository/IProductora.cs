using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IProductora
    {
        Task<IEnumerable<Productora>> GetAllProductora();
        Task<Productora> GetProductoraById(int id);
        Task<Productora> GetProductoraByName(string name);
        Task<bool> InsertProductora(Productora productora);
        Task<bool> UpdateProductora(Productora productora);
        Task<bool> DeleteProductora(int id);
        Task<bool> DeleteProductoraByName(string name);
    }
}
