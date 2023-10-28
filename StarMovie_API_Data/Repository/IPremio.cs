using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IPremio
    {
        Task<IEnumerable<Premio>> GetAllPremios();
        Task<Premio> GetPremio(int id);
        Task<Premio> GetPremioByName(string name);
        Task<bool> InsertPremio(Premio premio);
        Task<bool> UpdatePremio(Premio premio);
        Task<bool> DeletePremio(string id);
    }
}
