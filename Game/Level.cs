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
    public partial class Level : Form 
    {
        levelSpillPanel level1Panel = null;
        int timeLeft; // Tid du har på deg til å fullføre brettet 

        //Konstruktør for Level formen
        public Level(Login _loginref, string brukernavn)
        {
            InitializeComponent();
            level1Panel = new levelSpillPanel();
            this.Controls.Add(level1Panel);
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen

            lblBrukernavn.Text = "Brukernavn: " + brukernavn;
           
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
            btnStartSpill.Enabled = false;
            timeLeft = 300;
            timeLeftTimer.Enabled = true;
            timeLeftTimer.Start();
        }

        private void timeLeftTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left 
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                lblTid.Text = "Tid igjen: " + timeLeft;
                lblPoengsum.Text = "Poengsum: " + level1Panel.poengsum;
            }
            else
            {
                MessageBox.Show("Tiden er ute! " + Environment.NewLine + "Ballongen gikk tom for helium!");
                btnStartSpill.Enabled = true;
            }
    
        }
    }
}
