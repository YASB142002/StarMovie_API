using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Models
{
    public class Company
    {
        public int IdCompany { get; set; }
        public string Companyname { get; set;}
        public DateOnly Fundation {  get; set; }
        public string Paissede { get; set; }
        public int CEO { get; set; }
        public Blob website { get; set; }
        public string descrip { get; set; }
    }
}
