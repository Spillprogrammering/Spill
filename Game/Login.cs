using System;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;
            db.loginCheck(this, username, password);
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

        public void loginFinished()
        {
            
            FormView form = new FormView(this);
            form.Show();
            this.Hide();

        }
    }
}
