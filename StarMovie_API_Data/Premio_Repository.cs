using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Premio_Repository : IPremio
    {
        public Task<bool> DeletePremio(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Premio>> GetAllPremios()
        {
            throw new NotImplementedException();
        }

        public Task<Premio> GetPremio(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Premio> GetPremioByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPremio(Premio premio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePremio(Premio premio)
        {
            throw new NotImplementedException();
        }
    }
}
