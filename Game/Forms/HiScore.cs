using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Forms
{
    public partial class HiScore : Form
    {
        public HiScore()
        {
            InitializeComponent();
        }

        //Metode som kjøres når HiScore formen åpnes
        private void HiScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiScoreDataSet.Hiscore' table. You can move, or remove it, as needed.
            this.hiscoreTableAdapter.FillByScore(this.hiScoreDataSet.Hiscore);

        }

    }
}
