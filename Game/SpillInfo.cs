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
    public partial class SpillInfo : Form
    {
        private int x = 100;
        private int y = 200;
        private int z = -60;
        private int q = -60;
        private int bredde = 50;
        private int hoyde = 50;

        public SpillInfo()
        {
            InitializeComponent();
            System.Drawing.Graphics e;

        }


        private void tegn_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPie(Brushes.DarkTurquoise, x, y, z, q, bredde, hoyde);

            
        }

        private void btnlukk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
