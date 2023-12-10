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
    public partial class Edu_Form : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");
        public Edu_Form()
        {
            InitializeComponent();
            LoadDataEdu();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataEdu()
        {
            string queryDashboard = "SELECT `judulBuku`, `penulis`, `genre`, `penerbit`, `sinopsis` FROM `tb_tambahbuku` WHERE `genre`='Edukasi' ";
            MySqlCommand cmdDashboard = new MySqlCommand(queryDashboard, conn);

            try
            {
                conn.Open();
                MySqlDataAdapter daBuku = new MySqlDataAdapter(cmdDashboard);
                DataTable dtDashboard = new DataTable();
                daBuku.Fill(dtDashboard);

                // Isi DataGridView dengan data peminjaman yang belum dikembalikan
                dataGridView_Edu.DataSource = dtDashboard;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1: " + ex.Message);
            }
            conn.Close();

        }
    }
}
