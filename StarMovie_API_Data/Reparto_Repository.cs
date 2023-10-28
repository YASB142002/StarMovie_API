using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Reparto_Repository : IReparto
    {
        public Task<bool> DeleteReparto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reparto>> GetAllReparto()
        {
            throw new NotImplementedException();
        }

        public Task<Reparto> GetReparto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reparto> GetRepartoByActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertReparto(Reparto reparto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateReparto(Reparto reparto)
        {
            throw new NotImplementedException();
        }
    }
}
