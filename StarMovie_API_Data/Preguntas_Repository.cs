using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("dltCatgpeli", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ncatg", id);

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }

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
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("NPreguntas", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@intg", preguntas.Interrogante.Trim());

                    using (var adapt = new MySqlDataAdapter(cmd))
                    {
                        await adapt.FillAsync(data);
                        return true;
                    }
                }
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> UpdatePregunta(Preguntas preguntas)
        {
            try
            {
                var data = new DataSet();
                using (var cmd = new MySqlCommand("editpreguntas", dbConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idp", preguntas.Id_Pregunta);
                    cmd.Parameters.AddWithValue("@npregunta", preguntas.Interrogante.Trim());

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
