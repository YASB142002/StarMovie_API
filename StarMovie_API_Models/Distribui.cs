using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Distribui
    {
        public int IdDistribui { get; set; }
        public string Distriname { get; set; }
        public DateOnly Fundation {  get; set; }
        public string Paissede { get; set; }
        public string CEO { get; set; } 
        public Blob website { get; set; }
        public string descrip { get; set; }
    }
}
