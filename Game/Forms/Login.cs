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
    /// Klassen for Login-formen
    /// Dette er startmenyen hvor du kan navigere deg til HiScore listen, Registrer bruker eller logge inn
    /// @Author Halvard
    /// </summary>
    public partial class Login : Form
    {

        public Register regForm = new Register();
        private DBConnect db = new DBConnect();
        public Forms.HiScore hiScoreForm;
        
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

        #region Knapper
        /// Klikk metode for login knappen
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text; //Henter tekst fra tekstboksene
            string password = tbLoginPassword.Text;
            db.loginCheck(this, username, password); //kaller på loginCheck metoden i DBConnect klassen og sender med brukernavn og passord
        }
        
        /// Klikk metode for Registreringsknappen
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); //Gjemmer Login formen
            this.regForm.Show(); //Viser Registreringsformen
        }
        
        /// Klikk metode for Avslutt knappen
        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Avslutter applikasjonen
        }

        //Klikk metode for Poengtavle knappen
        private void btnHiScore_Click(object sender, EventArgs e)
        {
            hiScoreForm = new Forms.HiScore();
            hiScoreForm.Show(); //Viser HiScore listen
        }
        #endregion

        /// <summary>
        /// Metode for hva som skal skje når login er unnagjort
        /// </summary>
        public void loginFinished()
        {
            string brukernavn = tbLoginUsername.Text; //Henter ut brukernavnet fra tekstboksen
            Level form = new Level(this, brukernavn); //Oppretter Formen for spillet 
            form.Show(); //Viser spill formen
            this.Hide(); //Gjemmer Login formen
        }

       
    }
}
