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
    /// <summary>
    /// Form som viser Hiscore lista
    /// Inneholder kun en DataGridView som henter ut fra databasen
    /// 
    /// Spørringen som sendes mot databasen ser slik ut:
    /// SELECT Username, `Date`, Score FROM Hiscore ORDER BY Score DESC
    /// 
    /// @Author Halvard
    /// </summary>
    public partial class HiScore : Form
    {
        //Konstruktør
        public HiScore()
        {
            InitializeComponent();
        }

        //Metode som kjøres når HiScore formen åpnes
        private void HiScore_Load(object sender, EventArgs e)
        {
            this.hiscoreTableAdapter.FillByScore(this.hiScoreDataSet.Hiscore);
        }
    }
}
