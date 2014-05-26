using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Skytter
    {
        //Medlemsvariabler
        private Point[] punkt; //Punkt-array som skal ta vare på punktene (der skytteren skal plasseres)
        private GraphicsPath myPath = new GraphicsPath();
        private Brush brush = Brushes.Orange;


        /// <summary>
        /// Konstruktør for skytter
        /// </summary>
        /// <param name="_punkt"></param>
        public Skytter(Point[] _punkt)
        {
            punkt = _punkt;
            myPath.AddPolygon(punkt);
        }

        /// <summary>
        /// Tegne metoden for Skytteren
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            g.FillPolygon(brush, punkt);
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
