namespace PBO.Framex
{
    partial class Ensik_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ensik_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Rak = new System.Windows.Forms.Label();
            this.label_CloseDashboard = new System.Windows.Forms.Label();
            this.dataGridView_Ensik = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ensik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label_Rak);
            this.panel1.Controls.Add(this.label_CloseDashboard);
            this.panel1.Controls.Add(this.dataGridView_Ensik);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 576);
            this.panel1.TabIndex = 0;
            // 
            // label_Rak
            // 
            this.label_Rak.BackColor = System.Drawing.Color.Transparent;
            this.label_Rak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Rak.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rak.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Rak.Location = new System.Drawing.Point(510, 32);
            this.label_Rak.Name = "label_Rak";
            this.label_Rak.Size = new System.Drawing.Size(471, 46);
            this.label_Rak.TabIndex = 6;
            this.label_Rak.Text = "Rak Ensiklopedia";
            this.label_Rak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CloseDashboard
            // 
            this.label_CloseDashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_CloseDashboard.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CloseDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.label_CloseDashboard.Location = new System.Drawing.Point(1135, 9);
            this.label_CloseDashboard.Name = "label_CloseDashboard";
            this.label_CloseDashboard.Size = new System.Drawing.Size(38, 45);
            this.label_CloseDashboard.TabIndex = 4;
            this.label_CloseDashboard.Text = "x";
            this.label_CloseDashboard.Click += new System.EventHandler(this.label_CloseDashboard_Click);
            // 
            // dataGridView_Ensik
            // 
            this.dataGridView_Ensik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Ensik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ensik.Location = new System.Drawing.Point(294, 106);
            this.dataGridView_Ensik.Name = "dataGridView_Ensik";
            this.dataGridView_Ensik.RowHeadersWidth = 51;
            this.dataGridView_Ensik.RowTemplate.Height = 24;
            this.dataGridView_Ensik.Size = new System.Drawing.Size(879, 467);
            this.dataGridView_Ensik.TabIndex = 0;
            // 
            // Ensik_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ensik_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ensik_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ensik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_CloseDashboard;
        private System.Windows.Forms.DataGridView dataGridView_Ensik;
        private System.Windows.Forms.Label label_Rak;
    }
}