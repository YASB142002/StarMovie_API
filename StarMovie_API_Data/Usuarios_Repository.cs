using Dapper;
using MySql.Data.MySqlClient;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Usuarios_Repository : IUsuariosRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public Usuarios_Repository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteUsuario(string username)
        {
            var db = dbConnection();
            var sql = $@"call dltUsuario ('{username}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            var db = dbConnection();
            var sql = @"SELECT username, Pnombre, Snombre, PApellido, SApellido, fnacimiento, pssword, gmail, FP
                        FROM Usuarios";
            return await db.QueryAsync<Usuarios>(sql);
        }

        public async Task<Usuarios> GetUsuarioDetails(string username)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM Usuarios WHERE username = {username}";

            return await db.QueryFirstOrDefaultAsync<Usuarios>(sql);
        }

        public async Task<bool> InsertUsuario(Usuarios usuario)
        {
            var db = dbConnection();
            var sql = $@"call Nusuario('{usuario.Username}','{usuario.Pnombre}','{usuario.Snombre}','{usuario.PApellido}','{usuario.SApellido}','{usuario.fnacimiento}','{usuario.password}','{usuario.mail}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<bool> UpdateUsuario(string oldusername, Usuarios newuser )
        {
            var db = dbConnection();
            {
            var sql = $@"call edituser ('{oldusername}', '{newuser.Username}', '{newuser.password}', '{newuser.mail}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;

        }
    }
}
