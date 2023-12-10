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
    public partial class Rak_Form : Form
    {
        public Rak_Form()
        {
            InitializeComponent();
        }

        private void pictureBox_OnePeace_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 47; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Conan_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 52; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Bluelock_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 51; // ganti dengan id buku yang sesuai
            string imagePath = "KOMIK-BLUE LOCK.png";
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_DeathNote_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 54; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_DragonBall_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 53; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Haikyu_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 55; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_CeweCewe_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 50; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Naruto_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 49; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_TheirStory_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 56; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Preman_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 48; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);
            formInfoBuku.ShowDialog();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
