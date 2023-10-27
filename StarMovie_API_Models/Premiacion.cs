using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Premiacion
    {
        public string Premio {  get; set; }
        public int Id_Actor { get; set; }
        public DateOnly Fecha { get; set; }
    }
}
