using PBO.Classess;
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
using System.IO;
using ZstdSharp.Unsafe;
using Google.Protobuf.WellKnownTypes;

namespace PBO.Framex
{
    public partial class TambahBuku_Form : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;database=pebeo;password=");

        private readonly Buku_Form _parent;
        public string id_buku, judulBuku, penulis, genre, penerbit, sinopsis;

        // browse and display sampul buku
        private void button_PilihSampul_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // tipe image
            opf.Filter = "Pilih Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                // display Image in the pictureBox
                pictureBox_Sampul.Image = Image.FromFile(opf.FileName);
            }
        }


        public TambahBuku_Form(Buku_Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            label_TambahBuku.Text = "Update Buku";
            button_Simpan.Text = "Update";
            textBox_JudulBuku.Text = judulBuku;
            textBox_Penulis.Text = penulis;
            textBox_Genre.Text = genre;
            textBox_Penerbit.Text = penerbit;
            textBox_Sinopsis.Text = sinopsis;
        }

        public void Clear()
        {
            textBox_JudulBuku.Text = textBox_Penulis.Text = textBox_Penerbit.Text = textBox_Sinopsis.Text = textBox_Genre.Text = string.Empty;
            //pictureBox_Sampul.Image = null;
        }
        private void button_Simpan_Click(object sender, EventArgs e)
        {
            if (textBox_JudulBuku.Text.Trim().Length < 1)
            {
                MessageBox.Show("Judul buku masih kosong");
                return;
            }

            if (textBox_Penulis.Text.Trim().Length < 1)
            {
                MessageBox.Show("Penulis masih kosong");
                return;
            }

            if (textBox_Genre.Text.Trim().Length < 1)
            {
                MessageBox.Show("Genre masih kosong");
                return;
            }
            
            if (textBox_Penerbit.Text.Trim().Length < 1)
            {
                MessageBox.Show("Penerbit masih kosong");
                return;
            }

            if (textBox_Sinopsis.Text.Trim().Length < 1)
            {
                MessageBox.Show("Sinopsis masih kosong");
                return;
            }

            if (pictureBox_Sampul.Image == null)
            {
                MessageBox.Show("Sampul Buku masih kosong");
                return;
            }

            if(button_Simpan.Text == "Simpan")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_Sampul.Image.Save(ms, pictureBox_Sampul.Image.RawFormat);
                byte[] image = ms.ToArray();
                //byte[] image = image.save(ms, pictureBox_Sampul.Image.RawFormat);
                Buku_Class buku = new Buku_Class(textBox_JudulBuku.Text, textBox_Penulis.Text, textBox_Penerbit.Text, textBox_Genre.Text, textBox_Sinopsis.Text, image);
                dbsBuku.AddBuku(buku);
                Clear();
            }
            if(button_Simpan.Text == "Update")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_Sampul.Image.Save(ms, pictureBox_Sampul.Image.RawFormat);
                byte[] image = ms.ToArray();
                Buku_Class buku = new Buku_Class(textBox_JudulBuku.Text.Trim(), textBox_Penulis.Text.Trim(), textBox_Penerbit.Text.Trim(), textBox_Genre.Text.Trim(), textBox_Sinopsis.Text.Trim(), image);
                dbsBuku.UpdateBuku(buku, id_buku);
                //Clear();
            }

            _parent.Display();

            //AddBookLabelToRak();
        }

        /*private void AddBookLabelToRak()
        {
            // membuat label baru untuk menampilkan gambar buku
            Label newBookLabel = new Label();
            newBookLabel.Width = 100;
            newBookLabel.Height = 120;
            newBookLabel.Text = "";
            LoadAndDisplayBookImage(newBookLabel);

            // menentukan posisi label baru
            newBookLabel.Location = new Point(20, 20);

            // menambahkan label baru ke form rak
            Rak_Form.In
        }*/

        
    }
}
