using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PBO.Classess
{
    internal class Buku_Class
    {
        public string JudulBuku { get; set; }
        public string Penulis { get; set; }
        public string Genre { get; set; } 
        public string Penerbit { get; set; }
        public string Sinopsis { get; set; }
        public byte[] Cover { get; set; }
        //public string Status { get; set; }

        //public Buku_Class(string judulBuku, string penulis, string penerbit, string genre, string sinopsis, string status)
        public Buku_Class(string judulBuku, string penulis, string penerbit, string genre, string sinopsis, byte[] image)
        {
            JudulBuku = judulBuku;
            Penulis = penulis;
            Genre = genre;
            Penerbit = penerbit;
            Sinopsis = sinopsis;
            Cover = image;

            /*MemoryStream ms = new MemoryStream();
            
            byte[] image = ms.ToArray();*/
            //Cover = cover;
            //Status = status;

            //MemoryStream ms = new MemoryStream();
            //pictureBox_Sampul.Image.Save(ms, pictureBox_Sampul.Image.RawFormat);
            //sampul = ms.ToArray();
        }

        /*public Buku_Class(string text1, string text2, string text3, string text4, string text5, byte[] bytes)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.bytes = bytes;
        }*/
    }
}
