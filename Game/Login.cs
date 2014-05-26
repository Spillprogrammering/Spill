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
        
        /// <summary>
        /// Konstruktøren for Login klassen
        /// </summary>
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
            this.ControlBox = false; //Gjemmer "kontrollknappene" (Minimer, Maksimer og X)
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen
            InitializeComponent();
        }
        /// <summary>
        /// Klikk metode for login knappen
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text; //Henter tekst fra tekstboksene
            string password = tbLoginPassword.Text;
            db.loginCheck(this, username, password); //kaller på loginCheck metoden i DBConnect klassen og sender med brukernavn og passord
        }
        /// <summary>
        /// Klikk metode for Registreringsknappen
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); //Gjemmer Login formen
            this.regForm.Show(); //Viser Registreringsformen
        }
        /// <summary>
        /// Knapp som avslutter applikasjonen
        /// </summary>
        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Metode for hva som skal skje når login er unnagjort
        /// </summary>
        public void loginFinished()
        {
            Level form = new Level(this); //Oppretter Formen for spillet 
            form.Show(); //Viser spill formen
            this.Hide(); //Gjemmer Login formen
        }
    }
}
