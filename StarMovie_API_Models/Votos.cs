using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Votos
    {
        public string user_name {  get; set; }
        public int Id_Pelicula { get; set; }
        public double points { get; set; }
    }
}
