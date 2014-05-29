namespace Game
{
    partial class Register
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
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.tbRegFormUsername = new System.Windows.Forms.TextBox();
            this.tbRegFormPassword = new System.Windows.Forms.TextBox();
            this.tbRegFormPassword2 = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword2 = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegisterForm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(12, 41);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(62, 13);
            this.lblRegisterUsername.TabIndex = 0;
            this.lblRegisterUsername.Text = "Brukernavn";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(12, 67);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(45, 13);
            this.lblRegisterPassword.TabIndex = 1;
            this.lblRegisterPassword.Text = "Passord";
            // 
            // tbRegFormUsername
            // 
            this.tbRegFormUsername.Location = new System.Drawing.Point(116, 38);
            this.tbRegFormUsername.Name = "tbRegFormUsername";
            this.tbRegFormUsername.Size = new System.Drawing.Size(100, 20);
            this.tbRegFormUsername.TabIndex = 2;
            // 
            // tbRegFormPassword
            // 
            this.tbRegFormPassword.Location = new System.Drawing.Point(116, 64);
            this.tbRegFormPassword.Name = "tbRegFormPassword";
            this.tbRegFormPassword.PasswordChar = '*';
            this.tbRegFormPassword.Size = new System.Drawing.Size(100, 20);
            this.tbRegFormPassword.TabIndex = 3;
            // 
            // tbRegFormPassword2
            // 
            this.tbRegFormPassword2.Location = new System.Drawing.Point(116, 90);
            this.tbRegFormPassword2.Name = "tbRegFormPassword2";
            this.tbRegFormPassword2.PasswordChar = '*';
            this.tbRegFormPassword2.Size = new System.Drawing.Size(100, 20);
            this.tbRegFormPassword2.TabIndex = 4;
            // 
            // lblRegisterPassword2
            // 
            this.lblRegisterPassword2.AutoSize = true;
            this.lblRegisterPassword2.Location = new System.Drawing.Point(13, 90);
            this.lblRegisterPassword2.Name = "lblRegisterPassword2";
            this.lblRegisterPassword2.Size = new System.Drawing.Size(79, 13);
            this.lblRegisterPassword2.TabIndex = 5;
            this.lblRegisterPassword2.Text = "Gjenta Passord";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(13, 13);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(92, 13);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Registrer deg selv";
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.Location = new System.Drawing.Point(84, 137);
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.Size = new System.Drawing.Size(100, 23);
            this.btnRegisterForm.TabIndex = 7;
            this.btnRegisterForm.Text = "Registrer";
            this.btnRegisterForm.UseVisualStyleBackColor = true;
            this.btnRegisterForm.Click += new System.EventHandler(this.btnRegisterForm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(68, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Tilbake til innlogging";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 215);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterForm);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblRegisterPassword2);
            this.Controls.Add(this.tbRegFormPassword2);
            this.Controls.Add(this.tbRegFormPassword);
            this.Controls.Add(this.tbRegFormUsername);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.TextBox tbRegFormUsername;
        private System.Windows.Forms.TextBox tbRegFormPassword;
        private System.Windows.Forms.TextBox tbRegFormPassword2;
        private System.Windows.Forms.Label lblRegisterPassword2;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegisterForm;
        private System.Windows.Forms.Button btnCancel;
    }
}