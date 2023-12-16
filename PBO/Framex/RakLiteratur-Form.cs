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
    public partial class RakLiteratur_Form : Form
    {
        public RakLiteratur_Form()
        {
            InitializeComponent();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_TimunMas_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 99; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_DanauToba_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 95; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_JakaTarub_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 82; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_JokoKendil_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 84; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_LaDanadanKerbaunya_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 98; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_JokoBodo_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 97; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_SiPesu_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 96; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Sangkuriang_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 83; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_PutriTujuh_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 100; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_MalinKundang_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 85; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }
    }
}
