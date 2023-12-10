namespace PBO.Framex
{
    partial class NovSej_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovSej_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_NovSej = new System.Windows.Forms.DataGridView();
            this.label_Rak = new System.Windows.Forms.Label();
            this.label_CloseDashboard = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NovSej)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView_NovSej);
            this.panel1.Controls.Add(this.label_Rak);
            this.panel1.Controls.Add(this.label_CloseDashboard);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 575);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView_NovSej
            // 
            this.dataGridView_NovSej.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NovSej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NovSej.Location = new System.Drawing.Point(296, 105);
            this.dataGridView_NovSej.Name = "dataGridView_NovSej";
            this.dataGridView_NovSej.RowHeadersWidth = 51;
            this.dataGridView_NovSej.RowTemplate.Height = 24;
            this.dataGridView_NovSej.Size = new System.Drawing.Size(879, 467);
            this.dataGridView_NovSej.TabIndex = 10;
            // 
            // label_Rak
            // 
            this.label_Rak.BackColor = System.Drawing.Color.Transparent;
            this.label_Rak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Rak.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rak.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Rak.Location = new System.Drawing.Point(516, 30);
            this.label_Rak.Name = "label_Rak";
            this.label_Rak.Size = new System.Drawing.Size(471, 46);
            this.label_Rak.TabIndex = 9;
            this.label_Rak.Text = "Rak Novel Sejarah";
            this.label_Rak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CloseDashboard
            // 
            this.label_CloseDashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_CloseDashboard.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CloseDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.label_CloseDashboard.Location = new System.Drawing.Point(1134, 0);
            this.label_CloseDashboard.Name = "label_CloseDashboard";
            this.label_CloseDashboard.Size = new System.Drawing.Size(38, 45);
            this.label_CloseDashboard.TabIndex = 5;
            this.label_CloseDashboard.Text = "x";
            this.label_CloseDashboard.Click += new System.EventHandler(this.label_CloseDashboard_Click);
            // 
            // NovSej_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovSej_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovSej_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NovSej)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_NovSej;
        private System.Windows.Forms.Label label_Rak;
        private System.Windows.Forms.Label label_CloseDashboard;
    }
}