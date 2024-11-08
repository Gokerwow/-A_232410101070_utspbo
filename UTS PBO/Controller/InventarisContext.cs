using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.Model;

namespace UTS_PBO.Controller
{
    public class InventarisContext : DatabaseWrapper
    {
        private static string table = "inventaris";
        public static DataTable All()
        {
            string query = @"   
            SELECT
            id_inventaris,
            nama_barang,
            kategori,
            jumlah,
            harga
            FROM
            inventaris";

            DataTable dataInventaris = queryExecutor(query);
            return dataInventaris;
        }

        public static void AddInventaris(M_inventaris mahasiswaBaru)
        {
            string query = $"INSERT INTO {table} (nama_barang, kategori, jumlah_barang, harga) VALUES(@nama, @kategori, @jumlah, @harga)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", mahasiswaBaru.nama_barang),
                new NpgsqlParameter("@kategori", mahasiswaBaru.kategori),
                new NpgsqlParameter("@jumlah", mahasiswaBaru.jumlah),
                new NpgsqlParameter("@harga", mahasiswaBaru.harga),
            };

            commandExecutor(query, parameters);
        }
    }
}
