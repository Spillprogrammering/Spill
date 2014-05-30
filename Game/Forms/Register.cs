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
    /// <summary>
    /// Klasse for Registreringsformen
    /// Her registrerer man seg, og så kaller på en metode i DBConnect som sjekker om brukernavnet finnes allerede
    /// Hvis det ikke finnes fra før, blir man lagt til i databasen
    /// @Author Halvard
    /// </summary>
    public partial class Register : Form
    {
        private DBConnect db = new DBConnect();

        /// <summary>
        /// Konstruktøren for Register klassen
        /// </summary>
        public Register()
        {
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen
            this.ControlBox = false; //Gjemmer "kontrollknappene" (Minimer, Maksimer og X)
            InitializeComponent();
        }

        /// <summary>
        /// Klikk metode for tilbake til innlogging knappen
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login obj2 = new Login();
            obj2.regForm = this;
            this.Hide();
            obj2.Show();
        }

        /// <summary>
        /// Klikk metode for Registrer knappen
        /// </summary>
        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            if (tbRegFormPassword.Text.Equals(tbRegFormPassword2.Text)) //sjekker om passordene matcher
            {
                string username = tbRegFormUsername.Text; //henter ut brukernavn
                string password = tbRegFormPassword.Text; //henter ut passord
                db.registerUser(username, password); //Kaller på registerUser metoden i DBConnect klassen
            }
            else //hva som skjer hvis passordene ikke matcher
            {
                MessageBox.Show("Passordene matcher ikke!" + Environment.NewLine + "Prøv igjen", "Feil");
            }
        }

    }
}
