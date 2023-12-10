namespace PBO.Framex
{
    partial class Buku_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buku_Form));
            this.panel_InfoBuku = new System.Windows.Forms.Panel();
            this.label_InfoBuku = new System.Windows.Forms.Label();
            this.label_CloseTambahBuku = new System.Windows.Forms.Label();
            this.panel_Buku = new System.Windows.Forms.Panel();
            this.dataGridView_Buku = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.panel_InfoBuku.SuspendLayout();
            this.panel_Buku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_InfoBuku
            // 
            this.panel_InfoBuku.BackColor = System.Drawing.Color.Transparent;
            this.panel_InfoBuku.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_InfoBuku.Controls.Add(this.label_InfoBuku);
            this.panel_InfoBuku.Controls.Add(this.label_CloseTambahBuku);
            this.panel_InfoBuku.Location = new System.Drawing.Point(12, 12);
            this.panel_InfoBuku.Name = "panel_InfoBuku";
            this.panel_InfoBuku.Size = new System.Drawing.Size(1176, 94);
            this.panel_InfoBuku.TabIndex = 0;
            // 
            // label_InfoBuku
            // 
            this.label_InfoBuku.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoBuku.ForeColor = System.Drawing.SystemColors.Control;
            this.label_InfoBuku.Location = new System.Drawing.Point(40, 26);
            this.label_InfoBuku.Name = "label_InfoBuku";
            this.label_InfoBuku.Size = new System.Drawing.Size(181, 44);
            this.label_InfoBuku.TabIndex = 0;
            this.label_InfoBuku.Text = "Info Buku";
            this.label_InfoBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CloseTambahBuku
            // 
            this.label_CloseTambahBuku.AutoSize = true;
            this.label_CloseTambahBuku.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CloseTambahBuku.ForeColor = System.Drawing.SystemColors.Control;
            this.label_CloseTambahBuku.Location = new System.Drawing.Point(1135, -2);
            this.label_CloseTambahBuku.Name = "label_CloseTambahBuku";
            this.label_CloseTambahBuku.Size = new System.Drawing.Size(38, 45);
            this.label_CloseTambahBuku.TabIndex = 0;
            this.label_CloseTambahBuku.Text = "x";
            this.label_CloseTambahBuku.Click += new System.EventHandler(this.label_CloseTambahBuku_Click);
            // 
            // panel_Buku
            // 
            this.panel_Buku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.panel_Buku.Controls.Add(this.dataGridView_Buku);
            this.panel_Buku.Controls.Add(this.pictureBox1);
            this.panel_Buku.Controls.Add(this.textBox_search);
            this.panel_Buku.Controls.Add(this.button_Tambah);
            this.panel_Buku.Location = new System.Drawing.Point(12, 133);
            this.panel_Buku.Name = "panel_Buku";
            this.panel_Buku.Size = new System.Drawing.Size(1175, 455);
            this.panel_Buku.TabIndex = 0;
            // 
            // dataGridView_Buku
            // 
            this.dataGridView_Buku.AllowUserToAddRows = false;
            this.dataGridView_Buku.AllowUserToDeleteRows = false;
            this.dataGridView_Buku.AllowUserToResizeColumns = false;
            this.dataGridView_Buku.AllowUserToResizeRows = false;
            this.dataGridView_Buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Buku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Buku.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_Buku.GridColor = System.Drawing.Color.White;
            this.dataGridView_Buku.Location = new System.Drawing.Point(30, 100);
            this.dataGridView_Buku.MultiSelect = false;
            this.dataGridView_Buku.Name = "dataGridView_Buku";
            this.dataGridView_Buku.ReadOnly = true;
            this.dataGridView_Buku.RowHeadersWidth = 51;
            this.dataGridView_Buku.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Buku.RowTemplate.Height = 24;
            this.dataGridView_Buku.ShowEditingIcon = false;
            this.dataGridView_Buku.Size = new System.Drawing.Size(1111, 332);
            this.dataGridView_Buku.TabIndex = 0;
            this.dataGridView_Buku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Buku_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_buku";
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "judulBuku";
            this.Column2.HeaderText = "Judul Buku";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "penulis";
            this.Column3.HeaderText = "Penulis";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "penerbit";
            this.Column4.HeaderText = "Penerbit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "genre";
            this.Column5.HeaderText = "Genre";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sinopsis";
            this.Column6.HeaderText = "Sinopsis";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Edit";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Delete";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1113, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(873, 35);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(240, 22);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_Tambah
            // 
            this.button_Tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(97)))), ((int)(((byte)(111)))));
            this.button_Tambah.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Tambah.Location = new System.Drawing.Point(30, 26);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(105, 46);
            this.button_Tambah.TabIndex = 1;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = false;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // Buku_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel_Buku);
            this.Controls.Add(this.panel_InfoBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buku_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahBuku_Form";
            this.Shown += new System.EventHandler(this.Buku_Form_Shown);
            this.panel_InfoBuku.ResumeLayout(false);
            this.panel_InfoBuku.PerformLayout();
            this.panel_Buku.ResumeLayout(false);
            this.panel_Buku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InfoBuku;
        private System.Windows.Forms.Label label_CloseTambahBuku;
        private System.Windows.Forms.Label label_InfoBuku;
        private System.Windows.Forms.Panel panel_Buku;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}