using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Level : Form 
    {
        private DBConnect db = new DBConnect();
        levelSpillPanel level1Panel = null;
        int timeLeft; // Tid du har på deg til å fullføre brettet 
        Button btnGameOver = new Button();
        Label lgm = new Label();
        string username; //Brukt til å sende med brukernavnet til databasen
        private SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.game_over);

        //Konstruktør for Level formen
        public Level(Login _loginref, string _brukernavn)
        {
            InitializeComponent();

            
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen

            level1Panel = new levelSpillPanel();
            this.Controls.Add(level1Panel);
            
            lblBrukernavn.Text = "Brukernavn: " + _brukernavn; //Skriver brukernavnet du logget på med i labelen
            this.username = _brukernavn; //Henter ut brukernavnet
        }

        /// <summary>
        /// Metode for hva som skjer når du lukker Formen
        /// Avslutter spillet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Lukker applikasjonen ordentlig
        }

        //Klikk metode for Help knappen
        private void btnHelp_Click(object sender, EventArgs e)
        {
            SpillInfo spillInfo = new SpillInfo(); //Oppretter nytt SpillInfo form
            spillInfo.Show(); //Viser det nye SpillInfo formet
        }
        
        //Klikk metode for StartKnappen
        private void btnStartSpill_Click(object sender, EventArgs e)
        {
            spillPanel.Focus(); //Setter fokus til spillpanelet
            level1Panel.start(); //Kaller på start metoden i levelSpillPanel klassen
            lbGameOver.Visible = false;
            btnStartSpill.Enabled = false;
            level1Panel.Restart();
            timeLeft = 300;
            timeLeftTimer.Enabled = true;
            timeLeftTimer.Start();

        }

        // Timeren som holder rede på hvor lang tid du har igjen på å fullføre levelen sin Tick-metode
        private void timeLeftTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0) // Hvis du har mer tid igjen
            {
                lblPoengsum.Text = level1Panel.GetPoints();
                timeLeft = timeLeft - 1; //trekker fra 1 sekund per tick
                lblTid.Text = "Tid igjen: " + timeLeft; //Skriver gjenværende tid på labelen
            }
            else // Hvis tiden har gått ut
            {
                timeLeftTimer.Stop(); //stopper timeren
                sp.Play(); //Spiller av Game over lyd
                this.lbGameOver.Visible = true;
                btnStartSpill.Enabled = true;
                db.insertHiScore(username, level1Panel.GetPoengsum()); //Legger resultatet inn i Hiscore lista
            } 

        }


    }
}
