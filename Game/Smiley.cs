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
        private Brush color;
        private int x; //start posisjon
        private int y; // start posisjon
        private int z; // vinkel bue
        private int q; // vinkel spiss
        private int hoyde;
        private int bredde;
        private int verdi;
        

        /// <summary>
        /// Konstruktør for Smiley
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_z"></param>
        /// <param name="_q"></param>
        /// <param name="_hoyde"></param>
        /// <param name="_bredde"></param>
        /// <param name="_level"></param>
        public Smiley(int _x, int _y, int _z, int _q, int _hoyde, int _bredde, int _verdi)
        {
            x = _x;
            y = _y;
            z = _z;
            q = _q;
            hoyde = _hoyde;
            bredde = _bredde;
            verdi = _verdi;

            switch (_verdi)
            {
                case 1:
                    color = Brushes.DarkTurquoise;
                    verdi = 50;
                    break;

                case 2:
                    color = Brushes.Red;
                    verdi = 100;
                    break;
            }
        }

        /// <summary>
        /// Tegne metoden for "Smiley'en"
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            g.FillPie(color, x, y, z, q, bredde, hoyde);
        }


    }
}
