using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Votos
    {
        public int Id_Votos { get; set; }
        public string User_Name { get; set; }
        public int Id_Pelicula { get; set; }
        public double Points { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}