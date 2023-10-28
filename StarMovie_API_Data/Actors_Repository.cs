using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Actors_Repository : IActors
    {
        public Task<bool> DeleteActorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetActorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetActorByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Actor>> GetAllActors()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateActor(Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
