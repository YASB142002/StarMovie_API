using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Preguntas_Repository : IPreguntasRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public Preguntas_Repository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeletePregunta(int id)
        {
            var db = dbConnection();
            var sql = $@"call dltCatgpeli('{id}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<IEnumerable<Preguntas>> GetAllPreguntas()
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM preguntas";
            return await db.QueryAsync<Preguntas>(sql);
        }

        public async Task<Preguntas> GetPregunta(int id)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM preguntas WHERE idpregunta = {id}";
            return await db.QueryFirstOrDefaultAsync<Preguntas>(sql);
        }

        public async Task<bool> InsertPregunta(Preguntas preguntas)
        {
            var db = dbConnection();
            var sql = $@"call NPreguntas ('{preguntas.Interrogante}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<bool> UpdatePregunta(Preguntas preguntas)
        {
            var db = dbConnection();
            var sql = $@"call editpreguntas({preguntas.Id_Pregunta},'{preguntas.Interrogante}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }
    }
}
