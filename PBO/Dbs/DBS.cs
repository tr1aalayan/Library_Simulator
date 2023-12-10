using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PBO.Dbs
{
    internal class DBS
    {
        // koneksi database
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");

        // fungsi untuk open koneksi
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // fungsi untuk closed koneksi
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        // fungsi untuk return koneksi
        public MySqlConnection getConnection() { return con; }  

        // fungsi untuk return data tabel
        
    }
}
