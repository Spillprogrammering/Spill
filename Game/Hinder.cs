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
        private int hinder; //hvilket hinder som skal brukes

        /// <summary>
        /// Konstruktør for Hinder
        /// x1 og y1 er koordinat for hvor figuren skal "starte"
        /// y1 og x2 er koordinat for hvor figuren skal "slutte"
        /// </summary>
        /// <param name="_x1"></param>
        /// <param name="_x2"></param>
        /// <param name="_y1"></param>
        /// <param name="_y2"></param>
        /// <param name="_hinder"></param>
        public Hinder(int _x1, int _y1, int _x2, int _y2, int _hinder)
        {
            x1 = _x1;
            y1 = _y1;
            x2 = _x2;
            y2 = _y2;
            hinder = _hinder;

            /*
            myPath.StartFigure();
            myPath.AddEllipse(x, y, bredde, hoyde);
            myPath.AddEllipse(x, y, bredde +5, hoyde +5);
            myPath.CloseFigure();
            */

            switch (hinder)
            {
                case 1:
                    myPath.StartFigure(); //Nytt hinder
                    myPath.AddLine(x1, y1, x2, y2); 
                    myPath.AddLine(x1, y1 + 50, x2, y2 + 50);
                    myPath.CloseFigure(); //"Lukker" hinderet
                    break;
                case 2:
                    //myPath.StartFigure(); //Ny figur. 
                    myPath.AddArc(x1, y1, x2, y2, 0, -100);
                    //myPath.CloseFigure(); //Lukk!
                    break;
                case 3:
                    myPath.StartFigure();
                    myPath.AddRectangle(new Rectangle(x1, y1, x2, y2));
                    myPath.CloseFigure();
                    break;
                case 4:
                    myPath.StartFigure();
                    myPath.AddLine(x1, y1, x2, y2);
                    myPath.AddLine(x2, y2, x1, y1 - 200);
                    myPath.CloseFigure();
                    break;
            }


            /*
            myPath.StartFigure(); // Starter en figur. 
            myPath.AddLine(x, y, bredde, hoyde);
            myPath.AddLine(x + 5, y + 5, bredde + 5, hoyde + 5);
            myPath.CloseFigure(); //Lukk figuren!
             */
        }

        public void Draw(Graphics g)
        {
            g.FillPath(brush, myPath);
        }
    }
}
