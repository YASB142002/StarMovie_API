using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IVotosRepository
    {
        Task<IEnumerable<Votos>> GetAllVotos();
        Task<Votos> GetVotosDetails(int id);
        Task<bool> InsertVoto (Votos votos);
        Task<bool> UpdateVoto (Votos votos);
        Task<bool> DeleteVoto (int id);
    }
}
