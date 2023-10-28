using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IActors
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetActorById(int id);
        Task<Actor> GetActorByName(string name);
        Task<bool> InsertActor(Actor actor);
        Task<bool> UpdateActor(Actor actor);
        Task<bool> DeleteActorById(int id);
    }
}
