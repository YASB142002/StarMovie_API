using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class CEO_Repository : ICEO
    {
        public Task<bool> DeleteCEOById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCEOByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CEO> GetCEO()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCEO(CEO ceo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCEO(CEO ceo)
        {
            throw new NotImplementedException();
        }
    }
}
