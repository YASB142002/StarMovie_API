using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IPeliculas
    {
        Task<IEnumerable<Peliculas>> GetAllPeliculas();
        Task<Peliculas> GetPelicula(int id);
        Task<Peliculas> GetPeliculaByName (string name);
        Task<bool> InsertPelicula (Peliculas peliculas);
        Task<bool> UpdatePelicula (Peliculas pelicula);
        Task<bool> DeletePelicula (int id);
        Task<bool> DeletePeliculaByName (string name);
    }
}
