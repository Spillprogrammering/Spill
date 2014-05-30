using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Spillobjekter
{
    /// <summary>
    /// Klasse for kule-objektet
    /// @Author Halvard, Bjørn
    /// </summary>
    class Kule
    {
        #region Variabler
        public int x { get; set; } //startkordinater for kulen
        public int y { get; set; } // Startkordinater for kulen
        public int storrelse { get; set; } // Setter størrelsen på kulen
        private Brush brush = new SolidBrush(Color.Black); // Brush objekt
        public GraphicsPath kulePath = new GraphicsPath(); // Path til kulen
        private Region kuleRegionOpp; // Region for kulen, brukes til kollisjonsdeteksjon og flytting oppver
        private Region kuleRegionHøyre; // Region for kulen, brukes til kollisjonsdeteksjon og flytting til høyre
        private Region kuleRegionVenstre; // Region for kulen, brukes til kollisjonsdeteksjon og flytting til venstre
        private Region kuleRegionNed; // Region for kulen, brukes til kollisjonsdeteksjon og flytting nedover
        private int flytt = 0; // int for å flytte kulen i gitt rettning
        private int retning; // int som brukes til å finne rettning kulen skal skytes
        #endregion

        //Konstruktør
        public Kule(int _x, int _y, int _storrelse, int _retning)
        {
            x = _x;
            y = _y;
            storrelse = _storrelse;
            retning = _retning;

            
            // Inn i onPaint for løkke
            kulePath.StartFigure();
            kulePath.AddRectangle(new Rectangle(x, y, storrelse, storrelse));
            kulePath.CloseFigure();
             
        }
      
        // Getters & Setters
        public GraphicsPath getKulePath()
        {
            return kulePath;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public int Storrelse
        {
            get { return storrelse; }
        }

        // Metoder som tegner opp kulene, i forskjellige rettninger
        public void TegnOpp(Graphics e)
        {

            kuleRegionOpp = new Region(kulePath);
            kuleRegionOpp.Translate(0, flytt);
            flytt = flytt - 1;
            e.FillRegion(brush, kuleRegionOpp);

        }

        public void TegnHøyre(Graphics e)
        {
            kuleRegionHøyre = new Region(kulePath);
            kuleRegionHøyre.Translate(flytt, 0);
            flytt = flytt + 1;
            e.FillRegion(brush, kuleRegionHøyre);
        }

        public void TegnVenstre(Graphics e)
        {
            kuleRegionVenstre = new Region(kulePath);
            kuleRegionVenstre.Translate(flytt, 0);
            flytt = flytt - 1;
            e.FillRegion(brush, kuleRegionVenstre);
        }

        public void TegnNed(Graphics e)
        {
            kuleRegionNed = new Region(kulePath);
            kuleRegionNed.Translate(0, flytt);
            flytt = flytt + 1;
            e.FillRegion(brush, kuleRegionNed);
        }

        public int Retning
        {
            get { return retning; }
        }

    }
     
}
