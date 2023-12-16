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
    public partial class Dashboard_Form : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");
        public Dashboard_Form()
        {
            InitializeComponent();
            LoadDataDashboard();
        }

        private void button_Buku_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
        }

        /*private void button_PinjamBuku_Click(object sender, EventArgs e)
        {
            PinjamBuku_Form pinjam = new PinjamBuku_Form();
            pinjam.Show();
        }*/

        private void button_PengembalianBuku_Click(object sender, EventArgs e)
        {
            PengembalianBuku_Form pengembalian = new PengembalianBuku_Form();
            pengembalian.Show();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataDashboard()
        {
            string queryDashboard = "SELECT `judulBuku`, `penulis`, `genre`, `penerbit`, `sinopsis` FROM `tb_tambahbuku` ";
            MySqlCommand cmdDashboard = new MySqlCommand(queryDashboard, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter daBuku = new MySqlDataAdapter(cmdDashboard);
                DataTable dtDashboard = new DataTable();
                daBuku.Fill(dtDashboard);

                // Isi DataGridView dengan data peminjaman yang belum dikembalikan
                dataGridView_Dashboard.DataSource = dtDashboard;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1: " + ex.Message);
            }
            conn.Close();

        }

        private void button_NovSej_Click(object sender, EventArgs e)
        {
            RakNovel_Form novel = new RakNovel_Form();
            novel.Show();
        }

        private void button_HdP_Click(object sender, EventArgs e)
        {
            RakHukumPolitik_Form hukum = new RakHukumPolitik_Form();
            hukum.Show();
        }

        private void button_Litt_Click(object sender, EventArgs e)
        {
            RakLiteratur_Form literatur = new RakLiteratur_Form();
            literatur.Show();
        }

        private void button_Komik_Click(object sender, EventArgs e)
        {
            Rak_Form komik = new Rak_Form();
            komik.Show();
        }

        private void button_Edu_Click(object sender, EventArgs e)
        {
            RakEdu_Form edu = new RakEdu_Form();
            edu.Show();
        }

        private void button_Ensik_Click(object sender, EventArgs e)
        {
            RakEnsik_Form ensik = new RakEnsik_Form();
            ensik.Show();
        }

        private void button_Kelompok_Click(object sender, EventArgs e)
        {
            Kel4_Form kel4 = new Kel4_Form();
            kel4.Show();
        }
    }
}
