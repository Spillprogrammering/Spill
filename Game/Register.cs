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
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen
            this.ControlBox = false; //Gjemmer "kontrollknappene" (Minimer, Maksimer og X)
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login obj2 = new Login();
            obj2.regForm = this;
            this.Hide();
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
