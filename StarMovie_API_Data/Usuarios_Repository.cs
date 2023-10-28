using StarMovie_API_Data.Repository;
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

        public Task<Usuarios_Repository> GetUsers(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUser(Usuarios_Repository usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(Usuarios_Repository usuario)
        {
            throw new NotImplementedException();
        }
    }
}
