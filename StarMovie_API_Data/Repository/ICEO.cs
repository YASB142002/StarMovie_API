using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface ICEO
    {
        Task<CEO> GetCEO();
        Task<bool> InsertCEO(CEO ceo);
        Task<bool> UpdateCEO(CEO ceo);
        Task<bool> DeleteCEOById(int id);
        Task<bool> DeleteCEOByName(string name);
    }
}
