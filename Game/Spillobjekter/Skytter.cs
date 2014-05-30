using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Klasse for skytter-objektet
    /// @Author Halvard, Marcus, Bjørn
    /// </summary>
    class Skytter
    {
        //Medlemsvariabler
        //private Point[] punkt; //Punkt-array som skal ta vare på punktene (der skytteren skal plasseres)
        private GraphicsPath myPath = new GraphicsPath();
        private Brush brush = Brushes.Black;
        private int x; //start posisjon
        private int y; // start posisjon
        private int z; // vinkel bue
        private int q; // vinkel spiss
        private int hoyde;
        private int bredde;


        /// <summary>
        /// Konstruktør for skytter
        /// </summary>
        /// <param name="_punkt"></param>
        public Skytter(int _x, int _y, int _hoyde, int _bredde, int _z, int _q)
        {
            //punkt = _punkt;
            //myPath.AddPolygon(punkt);
            x = _x;
            y = _y;
            z = _z;
            q = _q;
            hoyde = _hoyde;
            bredde = _bredde;
        }

        /// <summary>
        /// Tegne metoden for Skytteren
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            //g.FillPolygon(brush, punkt);
            g.FillPie(brush, x, y, hoyde, bredde, z, q);
        }

        /// <summary>
        /// Metode for å få tak i banen til skytteren
        /// Brukt til kollisjonsdeteksjon
        /// </summary>
        /// <returns></returns>
        public GraphicsPath getPath()
        {
            return myPath;
        }
    }
}
