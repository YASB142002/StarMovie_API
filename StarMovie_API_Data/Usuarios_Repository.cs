using Dapper;
using MySql.Data.MySqlClient;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("dltUsuario", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usern", username.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
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
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("Nusuario", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usname", usuario.Username.Trim());
                    cmd.Parameters.AddWithValue("@Pname", usuario.Pnombre.Trim());
                    cmd.Parameters.AddWithValue("@Sname", usuario.Snombre.Trim());
                    cmd.Parameters.AddWithValue("@PA", usuario.PApellido.Trim());
                    cmd.Parameters.AddWithValue("@SA", usuario.SApellido.Trim());
                    cmd.Parameters.AddWithValue("@FNac", usuario.fnacimiento);
                    cmd.Parameters.AddWithValue("@Psword", usuario.password.Trim());
                    cmd.Parameters.AddWithValue("@mail", usuario.mail.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> UpdateUsuario(string oldusername, Usuarios newuser )
        {
            try
            {
                //El metodo de almacenado para editar el username de un usuario no deberia pedir para editar el username ya que seria el identificador
                var data = new DataSet();
                using (var cmd = new MySqlCommand("edituser", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usern", oldusername.Trim());
                    cmd.Parameters.AddWithValue("@nuevouser", newuser.Username.Trim());
                    cmd.Parameters.AddWithValue("@npssword", newuser.password.Trim());
                    cmd.Parameters.AddWithValue("@nmail", newuser.mail.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
        }
    }
}
