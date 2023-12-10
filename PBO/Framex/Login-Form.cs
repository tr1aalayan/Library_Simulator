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
using PBO.Dbs;

namespace PBO.Framex
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Dbs.DBS db = new Dbs.DBS();

            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tb_login` WHERE `Username`=@usn AND `Password`=@pass", db.getConnection());

            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            // cek
            if (dt.Rows.Count > 0)// jika berjalan
            {
                this.Close();
                
                Buku_Form tambah = new Buku_Form();
                tambah.Show();
            }
            else
            {
                // cek jika username kosong
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Masukkan Username anda untuk dapat Login sebagai Pustakawan", "Username kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // cek jika password kosong
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Masukkan Password anda untuk dapat Login sebagai Pustakawan", "Password kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // cek jika data salah
                else
                {
                    MessageBox.Show("Username dan Password salah!", "Data salah!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        

    }
}
