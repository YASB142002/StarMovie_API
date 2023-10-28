using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IReparto
    {
        Task<IEnumerable<Reparto>> GetAllReparto();
        Task<Reparto> GetReparto(int id);
        Task<Reparto> GetRepartoByActor(Actor actor);
        Task<bool> InsertReparto(Reparto reparto);
        Task<bool> UpdateReparto(Reparto reparto);
        Task<bool> DeleteReparto(int id);
    }
}
