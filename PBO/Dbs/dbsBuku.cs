using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PBO.Classess;
using System.Data;

namespace PBO.Dbs
{
    internal class dbsBuku
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost;port=3306;username=root;database=pebeo;password=";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return conn;
        }

        // Fungsi untuk menambahkan buku
        public static void AddBuku(Buku_Class buku)
        {
            // kalo di yt tidak ada tanda kutip '' pada tb_tambahbuku
            string sql = "INSERT INTO tb_tambahbuku (`id_buku`, `judulBuku`, `penulis`, `genre`, `penerbit`, `sinopsis`, `CreateAt`) VALUES (NULL, @JudulBuku, @Penulis, @Genre, @Penerbit, @Sinopsis, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@JudulBuku", MySqlDbType.VarChar).Value = buku.JudulBuku;
            cmd.Parameters.Add("@Penulis", MySqlDbType.VarChar).Value = buku.Penulis;
            cmd.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = buku.Genre;
            cmd.Parameters.Add("@Penerbit", MySqlDbType.VarChar).Value = buku.Penerbit;
            cmd.Parameters.Add("@Sinopsis", MySqlDbType.VarChar).Value = buku.Sinopsis;
            cmd.Parameters.Add("@Cover", MySqlDbType.LongBlob).Value = buku.Cover;
            //cmd.Parameters.Add("@Status", MySqlDbType.VarChar).Value = buku.Status;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Buku berhasil ditambahkan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Buku gagal ditambahkan \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        // Fungsi untuk mengupdate buku
        public static void UpdateBuku(Buku_Class buku, string id)
        {
            // kalo di yt tidak ada tanda kutip '' pada tb_tambahbuku
            string sql = "UPDATE tb_tambahbuku SET judulBuku = @JudulBuku, penulis = @Penulis, genre = @Genre, penerbit = @Penerbit,  sinopsis = @Sinopsis WHERE id_buku = @idbuku";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idbuku", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@JudulBuku", MySqlDbType.VarChar).Value = buku.JudulBuku;
            cmd.Parameters.Add("@Penulis", MySqlDbType.VarChar).Value = buku.Penulis;
            cmd.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = buku.Genre;
            cmd.Parameters.Add("@Penerbit", MySqlDbType.VarChar).Value = buku.Penerbit;
            cmd.Parameters.Add("@Sinopsis", MySqlDbType.VarChar).Value = buku.Sinopsis;
            cmd.Parameters.Add("@Cover", MySqlDbType.LongBlob).Value = buku.Cover;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update berhasil!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Buku gagal diupdate. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        // Fungsi untuk menghapus buku
        public static void DeleteBuku(string id)
        {
            string sql = "DELETE FROM tb_tambahbuku WHERE id_buku = @idbuku";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idbuku", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Buku berhasil dihapus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Buku gagal dihapus. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        // Fungsi untuk mengsearch
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }


    }
}
