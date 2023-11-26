using Dapper;
using MySql.Data.MySqlClient;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
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
            var db = dbConnection();
            var sql = $@"call dltCatgpeli('{id}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
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
            var db = dbConnection();
            var sql = $@"call NCatgPeli ('{catgPeli.NombreCatg}','{catgPeli.DescPeli}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<bool> UpdateCatgPeli(string oldcatname, CatgPeli catgPeli)
        {
            var db = dbConnection();
            //Hay que validar en el procedimiento de almacenado el nombre de categoria nuevo porque no puede ser null ya que la llave primaria jamas puede ser null
            var sql = $@"call editcatg('{oldcatname}', '{catgPeli.NombreCatg}', '{catgPeli.DescPeli}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }
    }
}
