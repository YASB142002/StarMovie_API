using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Votos_Repository : IVotos
    {
        public Task<bool> DeleteVoto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Votos>> GetAllVotos()
        {
            throw new NotImplementedException();
        }

        public Task<Votos> GetVotos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertVoto(Votos votos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateVoto(Votos votos)
        {
            throw new NotImplementedException();
        }
    }
}
