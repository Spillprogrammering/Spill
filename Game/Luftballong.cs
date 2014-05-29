using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Luftballong
    {
        //Medlemsvariabler
        //private PictureBox luftballong;
        public int x { get; set; } //startposisjon 
        public int y { get; set; } //startposisjon
        public int bx { get; set; } //bevegelsesposisjon
        public int by { get; set; } //bevegelsesposisjon
        

        public Luftballong(int _x, int _y, int _bx, int _by)
        {
            x = _x;
            y = _y;
            bx = _bx;
            by = _by;
        }


    }
}
