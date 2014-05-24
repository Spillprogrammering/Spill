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
       
        public Hinder()
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.StartFigure(); // Starter en figur. 
            myPath.AddLine(300, 150, 400, 190);
            myPath.AddLine(300, 260, 420, 290);
            myPath.CloseFigure(); //Lukk figuren!
        }
        
        public Object Hinder2()
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.StartFigure(); //Ny figur. 
            myPath.AddArc(175, 50, 50, 50, 0, -180);
            myPath.AddLine(100, 0, 250, 20);
            myPath.CloseFigure(); //Lukk!
            return myPath;
        }

        public Object Hinder3()
        {
            Point[] myPoints = {new Point(40, 60), new Point(50, 70), new Point(30, 90)};
            GraphicsPath myPath = new GraphicsPath();
            myPath.StartFigure(); //Ny figur. 
            myPath.AddLine(50, 20, 5, 90);
            myPath.AddCurve(myPoints, 3);
            myPath.AddLine(50, 150, 150, 180);
            myPath.CloseFigure(); //Lukk! 
            return myPath;
        }
   


    }
}
