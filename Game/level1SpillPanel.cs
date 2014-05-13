using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game
{
    class level1SpillPanel : Panel
    {
        //Konstruktør for spillpanelet
        public level1SpillPanel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }


        GraphicsPath myPath = new GraphicsPath();
        

    }
}
