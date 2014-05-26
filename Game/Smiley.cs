using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Smiley
    {
        //Medlemsvariabler
        private GraphicsPath myPath = new GraphicsPath();
        private Brush brush = Brushes.Yellow;
        private int x;
        private int y;
        private int hoyde;
        private int bredde;

        /// <summary>
        /// Konstruktør for Smiley
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_hoyde"></param>
        /// <param name="_bredde"></param>
        /// <param name="_level"></param>
        public Smiley(int _x, int _y, int _hoyde, int _bredde)
        {
            x = _x;
            y = _y;
            hoyde = _hoyde;
            bredde = _bredde;
        }

        /// <summary>
        /// Tegne metoden for "Smiley'en"
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            g.FillEllipse(brush, x, y, bredde, hoyde);
        }


    }
}
