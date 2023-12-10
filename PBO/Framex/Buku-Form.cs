using PBO.Dbs;
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
    public partial class Buku_Form : Form
    {

        TambahBuku_Form tambahbuku;
        public Buku_Form()
        {
            InitializeComponent();
            tambahbuku= new TambahBuku_Form(this);
        }

        private void label_CloseTambahBuku_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Display()
        {
            dbsBuku.DisplayAndSearch("SELECT id_buku, judulBuku, penulis, penerbit, genre, sinopsis FROM tb_tambahbuku", dataGridView_Buku);
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            //TambahBuku_Form tambahbuku = new TambahBuku_Form(this);

            tambahbuku.Clear();
            tambahbuku.ShowDialog();
        }

        private void Buku_Form_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            dbsBuku.DisplayAndSearch("SELECT id_buku, judulBuku, penulis, penerbit, genre, sinopsis FROM tb_tambahbuku WHERE judulBuku LIKE'%"+ textBox_search.Text +"%'", dataGridView_Buku);
        }

        private void dataGridView_Buku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                tambahbuku.Clear();
                tambahbuku.id_buku = dataGridView_Buku.Rows[e.RowIndex].Cells[2].Value.ToString();
                tambahbuku.judulBuku = dataGridView_Buku.Rows[e.RowIndex].Cells[3].Value.ToString();
                tambahbuku.penulis = dataGridView_Buku.Rows[e.RowIndex].Cells[4].Value.ToString();
                tambahbuku.penerbit = dataGridView_Buku.Rows[e.RowIndex].Cells[5].Value.ToString();
                tambahbuku.genre = dataGridView_Buku.Rows[e.RowIndex].Cells[6].Value.ToString();
                tambahbuku.sinopsis = dataGridView_Buku.Rows[e.RowIndex].Cells[7].Value.ToString();
                tambahbuku.UpdateInfo();
                tambahbuku.ShowDialog();
                // Edit
                return;
            }
            if(e.ColumnIndex == 1)
            {
                // Delete
                if(MessageBox.Show("Apa Anda ingin menghapus data buku ini?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dbsBuku.DeleteBuku(dataGridView_Buku.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
