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
    public partial class RakNovel_Form : Form
    {
        public RakNovel_Form()
        {
            InitializeComponent();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_KapalVanderWijck_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 44; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_RonggengDukuhParuk_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 41; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_OrangOrangProyek_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 39; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_MaxHavelaar_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 40; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_LautBercerita_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 36; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_HalamanTerakhir_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 42; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_GadisPantai_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 43; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_GadisKretek_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 37; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_CantikItuLuka_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 45; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Amba_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 38; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }
    }
}
