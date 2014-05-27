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
        private int x1; //X1 koordinat
        private int y1; //Y1 koordinat
        private int x2; //X2 koordinat
        private int y2; //Y2 koordinat
        private int hoyde; // høyde på hinder
        private int bredde; // bredde på hinder
        private int hinder; //hvilket hinder som skal brukes

        /// <summary>
        /// Konstruktør for Hinder med AddLine
        /// x1 og y1 er koordinat for hvor linjen skal "starte"
        /// y1 og x2 er koordinat for hvor linjen skal "slutte"
        /// </summary>
        /// <param name="_x1"></param>
        /// <param name="_x2"></param>
        /// <param name="_y1"></param>
        /// <param name="_y2"></param>
        public Hinder(int _x1, int _y1, int _x2, int _y2)
        {
            x1 = _x1;
            y1 = _y1;
            x2 = _x2;
            y2 = _y2;

            /*
            myPath.StartFigure();
            myPath.AddEllipse(x, y, bredde, hoyde);
            myPath.AddEllipse(x, y, bredde +5, hoyde +5);
            myPath.CloseFigure();
            */


            myPath.StartFigure(); // Starter en figur. 
            myPath.AddLine(x1, y1, x2, y2);
            myPath.AddLine(x1 + 5, y1 + 5, x2 + 5, y2 + 5);
            myPath.CloseFigure(); //Lukk figuren!
        }

       /// <summary>
       /// Konstruktør for Rektangel eller sirkel hinder
       /// 1 for rektangel
       /// 2 for sirkel
       /// </summary>
       /// <param name="_x1"></param>
       /// <param name="_y1"></param>
       /// <param name="_bredde"></param>
       /// <param name="_hoyde"></param>
       /// <param name="_hinder"></param>
        public Hinder(int _x1, int _y1, int _bredde, int _hoyde, int _hinder)
        {
            x1 = _x1;
            y1 = _y1;
            bredde = _bredde;
            hoyde = _hoyde;
            hinder = _hinder;

            switch  (hinder)
            {
                case 1: 
                    myPath.StartFigure();
                    myPath.AddRectangle(new Rectangle(x1, y1, bredde, hoyde));
                    myPath.CloseFigure();
                    break;
                case 2:
                    myPath.StartFigure();
                    myPath.AddEllipse(x1, y1, bredde, hoyde);
                    myPath.CloseFigure();
                    break;
            }
        }

       

        public void Draw(Graphics g)
        {
            g.FillPath(brush, myPath);
        }
    }
}
