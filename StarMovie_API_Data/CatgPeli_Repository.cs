using Dapper;
using MySql.Data.MySqlClient;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class CatgPeli_Repository : ICatgPeliRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public CatgPeli_Repository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteCatgPeli(string id)
        {
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("dltCatgpeli", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ncatg", id.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
        }

        public async Task<IEnumerable<CatgPeli>> GetAllCatgPelis()
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM catgpeli";
            return await db.QueryAsync<CatgPeli>(sql);
        }

        public async Task<CatgPeli> GetCatgPeli(string id)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM catgpeli WHERE NombreCatg = {id}";
            return await db.QueryFirstOrDefaultAsync<CatgPeli>(sql);
        }

        public async Task<bool> InsertCatgPeli(CatgPeli catgPeli)
        {
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("NCatgPeli", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Namecatg", catgPeli.NombreCatg.Trim());
                    cmd.Parameters.AddWithValue("@DescP", catgPeli.DescPeli.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> UpdateCatgPeli(string oldcatname, CatgPeli catgPeli)
        {
            var db = dbConnection();
            //Hay que validar en el procedimiento de almacenado el nombre de categoria nuevo porque no puede ser null ya que la llave primaria jamas puede ser null
            var sql = $@"call editcatg('{oldcatname}', '{catgPeli.NombreCatg}', '{catgPeli.DescPeli}');";
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("editcatg", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@catg", oldcatname.Trim());
                    cmd.Parameters.AddWithValue("@nuevocatg", catgPeli.NombreCatg.Trim());
                    cmd.Parameters.AddWithValue("@ndescpeli", catgPeli.DescPeli.Trim());

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
