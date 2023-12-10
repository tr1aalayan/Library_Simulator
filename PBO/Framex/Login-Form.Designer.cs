namespace PBO.Framex
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel_LoginForm = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CloseLogin = new System.Windows.Forms.Label();
            this.panel_LoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_LoginForm
            // 
            this.panel_LoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.panel_LoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_LoginForm.Controls.Add(this.button_Login);
            this.panel_LoginForm.Controls.Add(this.textBox_Password);
            this.panel_LoginForm.Controls.Add(this.textBox_Username);
            this.panel_LoginForm.Controls.Add(this.label_Password);
            this.panel_LoginForm.Controls.Add(this.label_Username);
            this.panel_LoginForm.Controls.Add(this.label2);
            this.panel_LoginForm.Controls.Add(this.label_CloseLogin);
            this.panel_LoginForm.Location = new System.Drawing.Point(12, 12);
            this.panel_LoginForm.Name = "panel_LoginForm";
            this.panel_LoginForm.Size = new System.Drawing.Size(558, 529);
            this.panel_LoginForm.TabIndex = 0;
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(225, 384);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(96, 39);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(178, 325);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(202, 22);
            this.textBox_Password.TabIndex = 5;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(178, 246);
            this.textBox_Username.Multiline = true;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 22);
            this.textBox_Username.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(175, 299);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(100, 23);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password :";
            // 
            // label_Username
            // 
            this.label_Username.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(175, 220);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(100, 23);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "Username :";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "PUSTAKAWAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CloseLogin
            // 
            this.label_CloseLogin.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CloseLogin.Location = new System.Drawing.Point(1135, 0);
            this.label_CloseLogin.Name = "label_CloseLogin";
            this.label_CloseLogin.Size = new System.Drawing.Size(38, 45);
            this.label_CloseLogin.TabIndex = 0;
            this.label_CloseLogin.Text = "x";
            this.label_CloseLogin.Click += new System.EventHandler(this.label_CloseLogin_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel_LoginForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.panel_LoginForm.ResumeLayout(false);
            this.panel_LoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LoginForm;
        private System.Windows.Forms.Label label_CloseLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
    }
}