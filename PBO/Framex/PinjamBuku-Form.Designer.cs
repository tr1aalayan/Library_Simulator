namespace PBO.Framex
{
    partial class PinjamBuku_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinjamBuku_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_InfoBuku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_bukuYgDipilih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Pinjam = new System.Windows.Forms.Button();
            this.comboBox_JudulBukuygdipinjam = new System.Windows.Forms.ComboBox();
            this.label_JudulBukuygdipinjam = new System.Windows.Forms.Label();
            this.textBox_NamaPeminjam = new System.Windows.Forms.TextBox();
            this.label_NamaPeminjam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_InfoBuku);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 94);
            this.panel1.TabIndex = 0;
            // 
            // label_InfoBuku
            // 
            this.label_InfoBuku.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoBuku.ForeColor = System.Drawing.SystemColors.Control;
            this.label_InfoBuku.Location = new System.Drawing.Point(36, 25);
            this.label_InfoBuku.Name = "label_InfoBuku";
            this.label_InfoBuku.Size = new System.Drawing.Size(296, 44);
            this.label_InfoBuku.TabIndex = 1;
            this.label_InfoBuku.Text = "Peminjaman Buku";
            this.label_InfoBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.textBox_bukuYgDipilih);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_Pinjam);
            this.panel2.Controls.Add(this.comboBox_JudulBukuygdipinjam);
            this.panel2.Controls.Add(this.label_JudulBukuygdipinjam);
            this.panel2.Controls.Add(this.textBox_NamaPeminjam);
            this.panel2.Controls.Add(this.label_NamaPeminjam);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 408);
            this.panel2.TabIndex = 1;
            // 
            // textBox_bukuYgDipilih
            // 
            this.textBox_bukuYgDipilih.Location = new System.Drawing.Point(174, 242);
            this.textBox_bukuYgDipilih.Name = "textBox_bukuYgDipilih";
            this.textBox_bukuYgDipilih.Size = new System.Drawing.Size(210, 22);
            this.textBox_bukuYgDipilih.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Judul Buku yang Dipilih :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Pinjam
            // 
            this.button_Pinjam.Location = new System.Drawing.Point(207, 330);
            this.button_Pinjam.Name = "button_Pinjam";
            this.button_Pinjam.Size = new System.Drawing.Size(148, 45);
            this.button_Pinjam.TabIndex = 5;
            this.button_Pinjam.Text = "Pinjam";
            this.button_Pinjam.UseVisualStyleBackColor = true;
            this.button_Pinjam.Click += new System.EventHandler(this.button_Pinjam_Click);
            // 
            // comboBox_JudulBukuygdipinjam
            // 
            this.comboBox_JudulBukuygdipinjam.FormattingEnabled = true;
            this.comboBox_JudulBukuygdipinjam.Location = new System.Drawing.Point(174, 164);
            this.comboBox_JudulBukuygdipinjam.Name = "comboBox_JudulBukuygdipinjam";
            this.comboBox_JudulBukuygdipinjam.Size = new System.Drawing.Size(210, 24);
            this.comboBox_JudulBukuygdipinjam.TabIndex = 4;
            // 
            // label_JudulBukuygdipinjam
            // 
            this.label_JudulBukuygdipinjam.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JudulBukuygdipinjam.Location = new System.Drawing.Point(171, 137);
            this.label_JudulBukuygdipinjam.Name = "label_JudulBukuygdipinjam";
            this.label_JudulBukuygdipinjam.Size = new System.Drawing.Size(213, 23);
            this.label_JudulBukuygdipinjam.TabIndex = 3;
            this.label_JudulBukuygdipinjam.Text = "Pilih Buku :";
            this.label_JudulBukuygdipinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_NamaPeminjam
            // 
            this.textBox_NamaPeminjam.Location = new System.Drawing.Point(174, 96);
            this.textBox_NamaPeminjam.Name = "textBox_NamaPeminjam";
            this.textBox_NamaPeminjam.Size = new System.Drawing.Size(210, 22);
            this.textBox_NamaPeminjam.TabIndex = 2;
            // 
            // label_NamaPeminjam
            // 
            this.label_NamaPeminjam.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaPeminjam.Location = new System.Drawing.Point(171, 69);
            this.label_NamaPeminjam.Name = "label_NamaPeminjam";
            this.label_NamaPeminjam.Size = new System.Drawing.Size(213, 23);
            this.label_NamaPeminjam.TabIndex = 1;
            this.label_NamaPeminjam.Text = "Nama Peminjam :";
            this.label_NamaPeminjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PinjamBuku_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PinjamBuku_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinjamBuku_Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_InfoBuku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_NamaPeminjam;
        private System.Windows.Forms.Label label_NamaPeminjam;
        private System.Windows.Forms.Button button_Pinjam;
        private System.Windows.Forms.ComboBox comboBox_JudulBukuygdipinjam;
        private System.Windows.Forms.Label label_JudulBukuygdipinjam;
        private System.Windows.Forms.TextBox textBox_bukuYgDipilih;
        private System.Windows.Forms.Label label2;
    }
}