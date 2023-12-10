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
    public partial class RakEnsik_Form : Form
    {
        public RakEnsik_Form()
        {
            InitializeComponent();
        }

        private void pictureBox_MitologiYunani_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 73; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_AnatomiManusia_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 72; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Astronomi_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 70; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_SejarahDunia_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 69; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_IlmuPengetahuanModern_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 67; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_PendidikanDanPsikologi_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 74; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_Psikologi_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 71; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_SejarahNasional_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 68; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_SukuSeniDanBudaya_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 76; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void pictureBox_MusikKlasik_Click(object sender, EventArgs e)
        {
            // mengirim id buku ke InfoBuku_Form
            int selectedBookId = 75; // ganti dengan id buku yang sesuai
            InfoBuku_Form formInfoBuku = new InfoBuku_Form(selectedBookId);

            formInfoBuku.ShowDialog();
        }

        private void label_CloseDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
