namespace PBO.Framex
{
    partial class PengembalianBuku_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengembalianBuku_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_PengembalianBuku = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_Pengembalian = new System.Windows.Forms.DataGridView();
            this.button_Kembalikan = new System.Windows.Forms.Button();
            this.button_Cari = new System.Windows.Forms.Button();
            this.textBox_CariNama = new System.Windows.Forms.TextBox();
            this.label_NamaPeminjamFormPengembalian = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pengembalian)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_PengembalianBuku);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 94);
            this.panel1.TabIndex = 1;
            // 
            // label_PengembalianBuku
            // 
            this.label_PengembalianBuku.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PengembalianBuku.ForeColor = System.Drawing.SystemColors.Control;
            this.label_PengembalianBuku.Location = new System.Drawing.Point(23, 21);
            this.label_PengembalianBuku.Name = "label_PengembalianBuku";
            this.label_PengembalianBuku.Size = new System.Drawing.Size(296, 44);
            this.label_PengembalianBuku.TabIndex = 1;
            this.label_PengembalianBuku.Text = "Pengembalian Buku";
            this.label_PengembalianBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.dataGridView_Pengembalian);
            this.panel2.Controls.Add(this.button_Kembalikan);
            this.panel2.Controls.Add(this.button_Cari);
            this.panel2.Controls.Add(this.textBox_CariNama);
            this.panel2.Controls.Add(this.label_NamaPeminjamFormPengembalian);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 455);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView_Pengembalian
            // 
            this.dataGridView_Pengembalian.AllowUserToAddRows = false;
            this.dataGridView_Pengembalian.AllowUserToDeleteRows = false;
            this.dataGridView_Pengembalian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Pengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pengembalian.Location = new System.Drawing.Point(395, 56);
            this.dataGridView_Pengembalian.Name = "dataGridView_Pengembalian";
            this.dataGridView_Pengembalian.ReadOnly = true;
            this.dataGridView_Pengembalian.RowHeadersWidth = 51;
            this.dataGridView_Pengembalian.RowTemplate.Height = 24;
            this.dataGridView_Pengembalian.Size = new System.Drawing.Size(756, 373);
            this.dataGridView_Pengembalian.TabIndex = 7;
            // 
            // button_Kembalikan
            // 
            this.button_Kembalikan.Location = new System.Drawing.Point(123, 138);
            this.button_Kembalikan.Name = "button_Kembalikan";
            this.button_Kembalikan.Size = new System.Drawing.Size(115, 47);
            this.button_Kembalikan.TabIndex = 6;
            this.button_Kembalikan.Text = "Kembalikan";
            this.button_Kembalikan.UseVisualStyleBackColor = true;
            this.button_Kembalikan.Click += new System.EventHandler(this.button_Kembalikan_Click);
            // 
            // button_Cari
            // 
            this.button_Cari.Location = new System.Drawing.Point(272, 82);
            this.button_Cari.Name = "button_Cari";
            this.button_Cari.Size = new System.Drawing.Size(49, 22);
            this.button_Cari.TabIndex = 5;
            this.button_Cari.Text = "Cari";
            this.button_Cari.UseVisualStyleBackColor = true;
            this.button_Cari.Click += new System.EventHandler(this.button_Cari_Click);
            // 
            // textBox_CariNama
            // 
            this.textBox_CariNama.Location = new System.Drawing.Point(62, 82);
            this.textBox_CariNama.Name = "textBox_CariNama";
            this.textBox_CariNama.Size = new System.Drawing.Size(210, 22);
            this.textBox_CariNama.TabIndex = 4;
            // 
            // label_NamaPeminjamFormPengembalian
            // 
            this.label_NamaPeminjamFormPengembalian.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaPeminjamFormPengembalian.Location = new System.Drawing.Point(59, 56);
            this.label_NamaPeminjamFormPengembalian.Name = "label_NamaPeminjamFormPengembalian";
            this.label_NamaPeminjamFormPengembalian.Size = new System.Drawing.Size(213, 23);
            this.label_NamaPeminjamFormPengembalian.TabIndex = 3;
            this.label_NamaPeminjamFormPengembalian.Text = "Nama Peminjam :";
            this.label_NamaPeminjamFormPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PengembalianBuku_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PengembalianBuku_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PengembalianBuku_Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pengembalian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_PengembalianBuku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Cari;
        private System.Windows.Forms.TextBox textBox_CariNama;
        private System.Windows.Forms.Label label_NamaPeminjamFormPengembalian;
        private System.Windows.Forms.Button button_Kembalikan;
        private System.Windows.Forms.DataGridView dataGridView_Pengembalian;
    }
}