using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Distribui_Repository : IDistribui
    {
        public Task<bool> DeleteDistribui(string id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDistribuiByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Distribui>> GetAllDistribui()
        {
            throw new NotImplementedException();
        }

        public Task<Distribui> GetDistribui(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Distribui> GetDistribuiByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertDistribui(Distribui distribui)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDistribui(Distribui distribui)
        {
            throw new NotImplementedException();
        }
    }
}
