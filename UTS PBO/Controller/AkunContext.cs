using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.Model;

namespace UTS_PBO.Controller
{
    public class AkunContext : DatabaseWrapper
    {
        private static string table = "akun";
        public static DataTable All()
        {
            string query = @"   
            SELECT
            id_akun,
            username,
            password,";

            DataTable dataInventaris = queryExecutor(query);
            return dataInventaris;
        }

        public static void AddAkun(M_Akun akunbaru)
        {
            string query = $"INSERT INTO {table} (usernam, password) VALUES(@username, @password)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", akunbaru.username),
                new NpgsqlParameter("@password", akunbaru.password),
            };

            commandExecutor(query, parameters);
        }
    }
}
