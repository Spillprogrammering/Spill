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
    class Hinder
    {
        private GraphicsPath myPath = new GraphicsPath(); // Oppretter nytt Graphics-path objekt
        private Brush brush = Brushes.GhostWhite; //farge på hinder
        private int x; //posisjon
        private int y; //posisjon
        private int hoyde; //høyde på hinder
        private int bredde; //bredde på hinder
        private int level; //tar vare på hvilket level man er på

        /// <summary>
        /// Konstruktør for hinder
        /// </summary>
        public Hinder(int _x, int _y, int _hoyde, int _bredde, int _level)
        {
            x = _x;
            y = _y;
            hoyde = _hoyde;
            bredde = _bredde;
            level = _level;



            /*
            myPath.StartFigure();
            myPath.AddEllipse(x, y, bredde, hoyde);
            myPath.AddEllipse(x, y, bredde +5, hoyde +5);
            myPath.CloseFigure();
            */
            
            myPath.StartFigure(); // Starter en figur. 
            myPath.AddLine(x, y, bredde, hoyde);
            myPath.AddLine(x + 5, y + 5, bredde + 5, hoyde + 5); //hardkodet, fiks!
            myPath.CloseFigure(); //Lukk figuren!
             
        }

        public void Draw(Graphics g)
        {
            g.FillPath(brush, myPath);
        }
    }
}
