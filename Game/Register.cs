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
    public partial class Register : Form
    {
        private DBConnect db = new DBConnect();

        public Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login obj2 = new Login();
            obj2.regForm = this;
            this.Close();
            obj2.Show();
        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            if (tbRegFormPassword.Text.Equals(tbRegFormPassword2.Text))
            {
                string username = tbRegFormUsername.Text;
                string password = tbRegFormPassword.Text;
                db.registerUser(username, password);

                
            }
            else
            {
                MessageBox.Show("Passordene matcher ikke!");
            }
        }

    }
}
