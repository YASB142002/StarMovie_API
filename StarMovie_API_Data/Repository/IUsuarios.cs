using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IUsuarios
    {
        Task<Usuarios> GetUsers(int id);
        Task<bool> InsertUser(Usuarios usuario);
        Task<bool> UpdateUser(Usuarios usuario);
        Task<bool> DeleteUser(int id);
    }
}
