using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IDistribui
    {
        Task<IEnumerable<Distribui>> GetAllDistribui();
        Task<Distribui> GetDistribui(int id);
        Task<Distribui> GetDistribuiByName(string name);
        Task<bool> InsertDistribui(Distribui distribui);
        Task<bool> UpdateDistribui(Distribui distribui);
        Task<bool> DeleteDistribui(string id);
        Task DeleteDistribuiByName(string name);
    }
}
