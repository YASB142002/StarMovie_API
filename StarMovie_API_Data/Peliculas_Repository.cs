using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Peliculas_Repository : IPeliculas
    {
        public Task<bool> DeletePelicula(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePeliculaByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Peliculas>> GetAllPeliculas()
        {
            throw new NotImplementedException();
        }

        public Task<Peliculas> GetPelicula(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Peliculas> GetPeliculaByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPelicula(Peliculas peliculas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePelicula(Peliculas pelicula)
        {
            throw new NotImplementedException();
        }
    }
}
