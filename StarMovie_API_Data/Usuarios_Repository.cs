using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Usuarios_Repository : IUsuarios
    {
        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> GetUsers(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUser(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(Usuarios usuario)
        {
            throw new NotImplementedException();
        }
    }
}
