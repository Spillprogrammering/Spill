﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Login : Form
    {

        public Register regForm = new Register();
        private DBConnect db = new DBConnect();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;
            db.loginCheck(username, password);
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.regForm.Show();
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
