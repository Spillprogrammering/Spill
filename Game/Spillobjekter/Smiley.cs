using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    /// <summary>
    /// Klasse for smileyobjektene (Ser ut som diamanter)
    /// @Author Halvard, Marcus, Bjørn
    /// </summary>
    class Smiley : Panel
    {
        //Medlemsvariabler
        private GraphicsPath myPath = new GraphicsPath();
        private Timer gravitasjon = new Timer();
        private Brush color;
        private int x; //start posisjon
        private int y; // start posisjon
        private int z; // vinkel bue
        private int q; // vinkel spiss
        private int hoyde;
        private int bredde;
        private int verdi { get; set; }
        private GraphicsPath smileyPath = new GraphicsPath();

        public int Verdi
        {
            get { return verdi;}

        }

        /// <summary>
        /// Konstruktør for Smiley
        /// </summary>
        public Smiley(int _x, int _y, int _z, int _q, int _hoyde, int _bredde, int _verdi)
        {
            x = _x;
            y = _y;
            z = _z;
            q = _q;
            hoyde = _hoyde;
            bredde = _bredde;
            verdi = _verdi;

            smileyPath.StartFigure();
            smileyPath.AddEllipse(x, y, bredde, hoyde);
            smileyPath.CloseFigure();


            switch (_verdi)
            {
                case 1:
                    color = Brushes.Yellow;
                    verdi = 50;
                    break;

                case 2:
                    color = Brushes.Red;
                    verdi = 100;
                    break;

                case 3:
                    color = Brushes.SeaGreen;
                    verdi = 150;
                    // omvent gravitasjon
                    //gravitasjon = Timer_Tick(y);
                    break;
            }
        }

        public GraphicsPath getPath()
        {
            return smileyPath;
        }

        // gravitasjon endring
        private void Timer_Tick (object sender)
        {
            if (y < this.Height + 20)
            {
                y += -2;
                Invalidate();
            }
        }

        /// <summary>
        /// Tegne metoden for "Smiley'en"
        /// </summary>
        public void Draw(Graphics g)
        {
            g.FillPie(color, x, y, z, q, bredde, hoyde);
        }


    }
}
