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
    /// Luftballong klassen
    /// @Author Halvard, Marcus, Bjørn
    /// </summary>
    class Luftballong
    {
        //Medlemsvariabler
        //private PictureBox luftballong;
        public int x { get; set; } //startposisjon 
        public int y { get; set; } //startposisjon
        public int bx { get; set; } //bevegelsesposisjon
        public int by { get; set; } //bevegelsesposisjon
        private GraphicsPath myPath;

        //Konstruktør
        public Luftballong(int _x, int _y, int _bx, int _by)
        {
            x = _x;
            y = _y;
            bx = _bx;
            by = _by;
        }
        
        //Metoden for å tegne luftballongen
        public void Draw(Graphics g)
        {
            g.DrawImage(Game.Properties.Resources.luftbalong1, new Point(10,10));
        }
        

    }
}
