using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Usuarios
    {
        public string Username { get; set; }
        public string Pnombre { get; set; }
        public string Snombre { get; set; }
        public string PApellido { get; set; }
        public string SApellido { get; set; }
        public DateTime fnacimiento 
        {
            get => fnacimiento;
            set
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL");
                fnacimiento = value;
            }
        }
        public string password { get; set; }
        public string mail { get; set; }
        public string FP { get; set; }
    }
}
