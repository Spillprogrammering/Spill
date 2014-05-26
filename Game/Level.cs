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


        //Konstruktør for Level formen
        public Level(Login _loginref)
        {
            InitializeComponent();
            level1Panel = new levelSpillPanel();
            this.Controls.Add(level1Panel);
            //(this as Control).KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bevegelse_KeyDown);
        }

        /// <summary>
        /// Metode for hva som skjer når du lukker Formen
        /// Avslutter spillet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
