using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace StarMovie_API_Models
{
    public class Usuarios
    {
        public string User_Name { get; set; }
        public string Pnombre { get; set;}
        public string? Snombre { get; set;}
        public string? PApellido { get; set;}
        public string? SApellido { get; set;}
        public DateOnly fnacimiento { get; set;}
        public string pssword { get; set;}
        public string? gmail { get; set;}
        public Blob? FP { get; set;}

    }
}
