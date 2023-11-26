using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IPreguntasRepository
    {
        Task<IEnumerable<Preguntas>> GetAllPreguntas();
        Task<Preguntas> GetPregunta(int id);
        Task<bool> InsertPregunta(Preguntas preguntas);
        Task<bool> UpdatePregunta(Preguntas preguntas);
        Task<bool> DeletePregunta(int id);
    }
}
