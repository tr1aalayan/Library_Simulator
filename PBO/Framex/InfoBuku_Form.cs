using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PBO.Framex
{
    public partial class InfoBuku_Form : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");
        private int bookId;
        //private string bookImagePath;

        public InfoBuku_Form(int selectedBookId)
        {
            InitializeComponent();
            bookId = selectedBookId;
            //bookImagePath = imagePath;
            LoadBookInfo();
            //DisplayBookImage();
            CheckBookStatus();
        }

        private void LoadBookInfo()
        {
            try
            {
                conn.Open();

                // ganti judul, penulis, genre, penerbit, dan sinopsis sesuai kolom di tabel buku
                string query = $"SELECT `judulBuku`, `penulis`, `genre`, `penerbit`, `sinopsis` FROM `tb_tambahbuku` WHERE `id_buku` = {bookId}";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // ganti label
                        
                        label_Judul.Text = reader["judulBuku"].ToString();
                        label_Penulis.Text = reader["penulis"].ToString();
                        label_Genre.Text = reader["genre"].ToString();
                        label_Penerbit.Text = reader["penerbit"].ToString();
                        label_Sinopsis.Text = reader["sinopsis"].ToString();
                        //pictureBox_InfoBuku.Ima;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        // code baru
        private void CheckBookStatus()
        {
            try
            {
                conn.Open();

                // Query untuk memeriksa status buku di tabel Peminjaman
                string query = $"SELECT `status` FROM `tb_peminjaman` WHERE id_buku = {bookId}";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object statusObj = cmd.ExecuteScalar();

                if (statusObj != null) // ID buku ada dalam tabel Peminjaman
                {
                    string status = statusObj.ToString();

                    // Jika status 'pinjam', nonaktifkan button
                    if (status == "Pinjam")
                    {
                        button_Pinjam.Enabled = false;
                        label_status.Text = "Buku sedang dipinjam.";
                        //MessageBox.Show("Buku sedang dipinjam.");
                    }
                    else
                    {
                        button_Pinjam.Enabled = true;
                    }
                }
                else // ID buku tidak ada dalam tabel Peminjaman
                {
                    button_Pinjam.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            conn.Close();
        }

        private void button_Pinjam_Click(object sender, EventArgs e)
        {
            
            // Proses peminjaman
            string judulBuku = label_Judul.Text;
            string genre = label_Genre.Text;
            int idBuku = bookId;


            //string queryPeminjaman = $"UPDATE `tb_tambahbuku` SET `status`='Tidak Tersedia' WHERE id_buku = {idBuku}";
            string queryPeminjaman = $"INSERT INTO `tb_peminjaman`(`id_buku`, `judulBuku`, `genre`, `status`) VALUES ({idBuku}, '{judulBuku}', '{genre}', 'Pinjam')";
            MySqlCommand cmdPeminjaman = new MySqlCommand(queryPeminjaman, conn);
            CheckBookStatus();

            try
            {
                conn.Open();
                cmdPeminjaman.ExecuteNonQuery();
                MessageBox.Show("Buku berhasil dipinjam!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //CheckBookStatus() ;
        }



        /*private void DisplayBookImage()
        {
            if(!string.IsNullOrEmpty(bookImagePath))
            {
                pictureBox_InfoBuku.Image = Image.FromFile(bookImagePath);
            }
        }*/

    }
}
