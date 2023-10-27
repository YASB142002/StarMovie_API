using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string NamePeli {get; set; }
        public string DescPeli { get; set; }
        public string catg_Peli { get; set; }
        public string clasi_EDad {  get; set; }
        public string name_Prod { get; set; }
        public double puntuacion { get; set; }
    }
}
