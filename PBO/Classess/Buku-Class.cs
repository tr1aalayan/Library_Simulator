using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Classess
{
    internal class Buku_Class
    {
        public string JudulBuku { get; set; }
        public string Penulis { get; set; }
        public string Genre { get; set; } 
        public string Penerbit { get; set; }
        public string Sinopsis { get; set; }
        //public string Status { get; set; }

        //public Buku_Class(string judulBuku, string penulis, string penerbit, string genre, string sinopsis, string status)
        public Buku_Class(string judulBuku, string penulis, string penerbit, string genre, string sinopsis)
        {
            JudulBuku = judulBuku;
            Penulis = penulis;
            Genre = genre;
            Penerbit = penerbit;
            Sinopsis = sinopsis;
            //Status = status;
        }
    }
}
