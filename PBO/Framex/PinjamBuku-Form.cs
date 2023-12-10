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
    public partial class PinjamBuku_Form : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");

        public PinjamBuku_Form()
        {
            InitializeComponent();
            LoadDataBuku();

        }

        private void LoadDataBuku()
        {
            // Ambil data buku dari database dan isi ComboBox
            string query = "SELECT `id_buku`, `judulBuku` FROM `tb_tambahbuku` ";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Isi ComboBox dengan data buku
                comboBox_JudulBukuygdipinjam.DisplayMember = "judulBuku";
                comboBox_JudulBukuygdipinjam.ValueMember = "id_buku";
                //comboBox_JudulBukuygdipinjam.ValueMember = "judulBuku";
                comboBox_JudulBukuygdipinjam.DataSource = dt;
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

        private void button_Pinjam_Click(object sender, EventArgs e)
        {
            // Proses peminjaman
            string namaPeminjam = textBox_NamaPeminjam.Text;
            string judulBuku = textBox_bukuYgDipilih.Text;
            int idBuku = Convert.ToInt32(comboBox_JudulBukuygdipinjam.SelectedValue);


            //string queryPeminjaman = $"UPDATE `tb_tambahbuku` SET `status`='Tidak Tersedia' WHERE id_buku = {idBuku}";
            string queryPeminjaman = $"INSERT INTO `tb_peminjaman`(`id_buku`, `namaPeminjam`, `judulBuku`, `status`) VALUES ({idBuku}, '{namaPeminjam}', '{judulBuku}', 'Pinjam')";
            MySqlCommand cmdPeminjaman = new MySqlCommand(queryPeminjaman, conn);

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
