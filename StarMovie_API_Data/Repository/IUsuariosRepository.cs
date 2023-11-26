using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface IUsuariosRepository
    {
        Task<IEnumerable<Usuarios>> GetAllUsuarios();
        Task<Usuarios> GetUsuarioDetails(string username);
        Task<bool> InsertUsuario(Usuarios usuario);
        Task<bool> UpdateUsuario(string oldusername, Usuarios newuser);
        Task<bool> DeleteUsuario(string username);
    }
}
