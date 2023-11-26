﻿using Dapper;
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
    public class Votos_Repository : IVotosRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public Votos_Repository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteVoto(int id)
        {
            var db = dbConnection();
            var sql = @"call dltvotos(" + id + ");";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }

        public async Task<IEnumerable<Votos>> GetAllVotos()
        {
            var db = dbConnection();

            var sql = @"SELECT *
                        FROM votos";

            return await db.QueryAsync<Votos>(sql);
        }

        public async Task<Votos> GetVotosDetails(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT *
                        FROM votos 
                        WHERE idvotos = " + id.ToString();

            return await db.QueryFirstOrDefaultAsync<Votos>(sql);
        }

        public async Task<bool> InsertVoto(Votos votos)
        {
            var db = dbConnection();

            var sql = $@"call Nvotos ('{votos.User_Name}',{votos.Id_Pelicula},{votos.Points},'{votos.Comentario}');";

            var result = await db.ExecuteAsync(sql);

            return result > 0;
        }

        public async Task<bool> UpdateVoto(Votos votos)
        {
            var db = dbConnection();
            var sql = $@"call editvotos({votos.Id_Votos}, {votos.Points},'{votos.Comentario}');";
            var result = await db.ExecuteAsync(sql);
            return result > 0;
        }
    }
}
