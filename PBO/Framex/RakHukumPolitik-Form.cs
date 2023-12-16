using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO.Framex
{
    public partial class RakHukumPolitik_Form : Form
    {
        public RakHukumPolitik_Form()
        {
            InitializeComponent();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_WhatWouldYourLawyerSay_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 80; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_TeknikPembuatanAktaBU_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 101; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_OmnibusLAW_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 81; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_MatinyaKepakaran_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 102; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_HukumPidanaInternasional_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 79; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_TeoriHansTentangHukum_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 104; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_CyberBullying_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 77; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_FilsafatKeadilan_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 78; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_HukumAdatIndonesia_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 103; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_PolitikHukum_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 105; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }
    }
}
