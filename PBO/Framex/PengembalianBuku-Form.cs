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
    public partial class PengembalianBuku_Form : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");

        public PengembalianBuku_Form()
        {
            InitializeComponent();
            LoadDataPeminjaman();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataPeminjaman()
        {
            string queryPeminjaman = "SELECT * FROM `tb_peminjaman` WHERE `status`='Pinjam'";
            MySqlCommand cmdPeminjaman = new MySqlCommand(queryPeminjaman, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter daPeminjaman = new MySqlDataAdapter(cmdPeminjaman);
                DataTable dtPeminjaman = new DataTable();
                daPeminjaman.Fill(dtPeminjaman);

                // Isi DataGridView dengan data peminjaman yang belum dikembalikan
                dataGridView_Pengembalian.DataSource = dtPeminjaman;
                //conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error1: " + ex.Message);
            }
            conn.Close();
            
        }

        private void button_Cari_Click(object sender, EventArgs e)
        {
            // Proses mencari peminjaman berdasarkan nama peminjam
            string namaPeminjam = textBox_CariNama.Text;
            string query = $"SELECT * FROM `tb_peminjaman` WHERE `status`='Pinjam' AND `namaPeminjam`LIKE'%{namaPeminjam}%'";
            MySqlCommand cmdCari = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdCari);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Isi DataGridView dengan data peminjaman
                dataGridView_Pengembalian.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error2: " + ex.Message);
            }
            conn.Close();
            
        }

        private void button_Kembalikan_Click(object sender, EventArgs e)
        {
            if (dataGridView_Pengembalian.SelectedRows.Count > 0)
            {
                // Ambil ID peminjaman dari baris terpilih
                int idPeminjaman = Convert.ToInt32(dataGridView_Pengembalian.SelectedRows[0].Cells["id_peminjaman"].Value);

                // Query untuk menghapus data peminjaman setelah buku dikembalikan
                string queryKembalikan = $"DELETE FROM `tb_peminjaman` WHERE `id_peminjaman` = {idPeminjaman}";
                MySqlCommand cmdKembalikan = new MySqlCommand(queryKembalikan, conn);

                try
                {
                    conn.Open();
                    cmdKembalikan.ExecuteNonQuery();
                    MessageBox.Show("Buku berhasil dikembalikan!");

                    // Memuat ulang data setelah pengembalian buku
                    LoadDataPeminjaman();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error3: " + ex.Message);
                }
                conn.Close();
                
            }
            else
            {
                MessageBox.Show("Pilih baris peminjaman yang ingin dikembalikan.");
                //conn.Close();
            }
            //conn.Close();
        }
    }
}
