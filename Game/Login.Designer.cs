﻿namespace Game
{
    partial class Login
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
            this.lblVelkommen = new System.Windows.Forms.Label();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVelkommen
            // 
            this.lblVelkommen.AutoSize = true;
            this.lblVelkommen.Location = new System.Drawing.Point(136, 76);
            this.lblVelkommen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVelkommen.Name = "lblVelkommen";
            this.lblVelkommen.Size = new System.Drawing.Size(81, 17);
            this.lblVelkommen.TabIndex = 0;
            this.lblVelkommen.Text = "Velkommen";
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(113, 105);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(132, 22);
            this.tbLoginUsername.TabIndex = 1;
            this.tbLoginUsername.Text = "Marcus";
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(113, 138);
            this.tbLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(132, 22);
            this.tbLoginPassword.TabIndex = 2;
            this.tbLoginPassword.Text = "marcus";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 171);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Logg inn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(113, 207);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 28);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrer deg";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Location = new System.Drawing.Point(113, 242);
            this.btnLoginExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(133, 28);
            this.btnLoginExit.TabIndex = 5;
            this.btnLoginExit.Text = "Avslutt";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 348);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Controls.Add(this.lblVelkommen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVelkommen;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLoginExit;
    }
}