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

        /*private void DisplayBookImage()
        {
            if(!string.IsNullOrEmpty(bookImagePath))
            {
                pictureBox_InfoBuku.Image = Image.FromFile(bookImagePath);
            }
        }*/

    }
}
