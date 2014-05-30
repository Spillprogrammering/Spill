using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Media;
using Game.Spillobjekter;

namespace Game
{
    /// <summary>
    /// Klasse for Panelet man spiller i
    /// @Author Halvard, Marcus, Bjørn
    /// </summary>
    class levelSpillPanel : Panel
    {
        #region Variabler
        private Luftballong luftballong = new Luftballong(10,10,2,3); //Luftballong
        private PictureBox luftballongBilde = new PictureBox();
        private SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.gatherGemSound); //Lyd når du plukker opp samleobjekt (diamant)
        
        private bool running = false; //Boolsk variabel som skal brukes til å sjekke om spillet kjører eller ikke
        private System.Windows.Forms.Timer timer; //timer brukt til gravitasjon
        private static int poengsum;
        private GraphicsPath luftBallongPath = new GraphicsPath();


        private List<Hinder> hinderListe = new List<Hinder>(); //Liste som tar vare på alle Hinder-objekter
        private List<Skytter> skytterListe = new List<Skytter>(); //Liste som tar vare på alle Skyttere
        private List<Smiley> smileyListe = new List<Smiley>(); //Liste som tar vare på alle smileyfjes
        private List<Kule> kuleListe = new List<Kule>(); //Liste som tar vare på alle kulene
        #endregion


        //Konstruktør for spillpanelet
        public levelSpillPanel()
        {
            //Fjerner "blinking" når spillet tegnes
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            tegnFigurer(); // Kaller på metode som legger alle figurer inn i lister

            //Timer til gravitasjon
            timer = new System.Windows.Forms.Timer(); //Oppretter timer
            timer.Interval = 20; //Setter intervallet mellom hvert "tick"
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();

            //Legger til luftballongen
            luftballongBilde.Image = Game.Properties.Resources.luftbalong1;
            luftballongBilde.Size = new System.Drawing.Size(31, 60); //setter størrelsen på luftballong bildet
            luftballongBilde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Controls.Add(luftballongBilde);
        }


        /// <summary>
        /// Metode som oppretter figurer og legger dem i en liste
        /// </summary>
        public void tegnFigurer()
        {
            //Hindere
            hinderListe.Add(new Hinder(120, 0, 20, 100, 1)); 
            hinderListe.Add(new Hinder(0, 160, 20, 10, 1));
            hinderListe.Add(new Hinder(240, 0, 20, 100, 1)); 
            hinderListe.Add(new Hinder(175, 250, 30, 30, 2)); 
            hinderListe.Add(new Hinder(300, 250, 400, 250)); 
            hinderListe.Add(new Hinder(620, 30, 50, 50, 2)); 
            //Smileys
            smileyListe.Add(new Smiley(170, 35, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(75, 250, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(318, 220, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(30, 450, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(500, 100, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(632, 270, 50, 50, -60, -60, 3));
            //Skyttere            
            skytterListe.Add(new Skytter(155, 430, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(610, 430, 80, 80, 70, 40));
            //Kuler
            kuleListe.Add(new Kule(193, 470,5, 1));
            kuleListe.Add(new Kule(648, 470, 5, 1));
        }

        /// <summary>
        /// Overstyrer OnPaint metoden
        /// Kalles på hver gang man kjører Invalidate()
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); //videresender til onpaint superklassen
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Glatter ut kantene til objektene
            luftballongBilde.Location = new Point(luftballong.x, luftballong.y); //Setter posisjonen til luftballongen
            Rectangle rec = new Rectangle(luftballong.x - 40, luftballong.y - 30, 10, 40); // Setter størrelsen på rektangelet i diamantene
            luftBallongPath.StartFigure();
            luftBallongPath.AddRectangle(rec);
            luftBallongPath.CloseFigure();

            //Går igjennom listene med figurer og tegner dem
            //Hinderlisten
            for (int i = 0; i < hinderListe.Count; i++) 
            {
                Hinder hinder = hinderListe[i];


                if (checkCollisionHinder(luftBallongPath, hinder.getPath(), e)) //Kaller på metoden som sjekker om luftballong kolliderer med hinder
                {
                    //Gjør ingenting atm, for det er en bug
                }

                hinder.Draw(e.Graphics); //Kaller på tegne metoden for hinder
            }
            //Skytterlisten
            for (int i = 0; i < skytterListe.Count; i++)
            {
                Skytter skytter = skytterListe[i];
                skytter.Draw(e.Graphics); //Kaller på tegne metoden for skytterne
            }
            //Smileylisten
            for (int i = 0; i < smileyListe.Count; i++)
            {
                Smiley smiley = smileyListe[i];

                if (checkcollision(luftBallongPath, smiley.getPath(), e)) //Sjekker om man har kollidert med en Smiley
                {
                    smileyListe.RemoveAt(i); // fjerner diamanten når kollisjonen inntreffer 
                    int verdi = smileyListe[i].Verdi; //Finner verdien til diamanten
                    poengsum += verdi; //Legger til verdien til diamanten
                }

                smiley.Draw(e.Graphics); //Kaller på tegne metoden for "Smileys"
            }
            //Kulelisten
            for (int i = 0; i < kuleListe.Count; i++)
            {
                Kule kule = kuleListe[i];

                // Sjekk for å bestemme retningen på kulene
                if (kule.Retning == 1)
                {
                    kule.TegnOpp(e.Graphics);
                }
                else if (kule.Retning == 2)
                {
                    kule.TegnHøyre(e.Graphics);
                }
                else if (kule.Retning == 3)
                {
                    kule.TegnVenstre(e.Graphics);
                }
                else if (kule.Retning == 4)
                {
                    kule.TegnNed(e.Graphics);
                }

                // Sjekker kollisjon mellom ballong og kule
                if (checkCollisionKule(luftBallongPath, kule.getKulePath(), e)) // Sjekker om man har kollidert med en Kule
                {
                    sp.Play();
                }
            }
        }

        // check for kollisjon mellom ballong og hinder
        public bool checkCollisionHinder(GraphicsPath luftballongBilde, GraphicsPath hinderListe, PaintEventArgs e)
        {
            Region lb = new Region(luftballongBilde); 
            Region hl = new Region(hinderListe);
            lb.Intersect(hl);
            if (!lb.IsEmpty(e.Graphics))
            {
                return true;
            }
            else
                return false;
        }

        // check for kollisjon mellom ballong og kule
        public bool checkCollisionKule(GraphicsPath luftballongBilde, GraphicsPath kuleListe, PaintEventArgs e)
        {
            Region lb = new Region(luftballongBilde);
            Region kl = new Region(kuleListe);
            lb.Intersect(kl);
            if (!lb.IsEmpty(e.Graphics))
            {
                return true;
            }
            else
                return false;
        }

        // check for kollisjon mellom ballong og diamant 
        public bool checkcollision(GraphicsPath luftballongBilde, GraphicsPath smileyListe, PaintEventArgs e) 
        { 
            Region lb = new Region(luftballongBilde); 
            Region sl = new Region(smileyListe); 
            lb.Intersect(sl);
            if (!lb.IsEmpty(e.Graphics)) 
            {
                sp.Play();
                return true;
            }
            else
                return false;
        }

        /*
        public kollisjonSjekk(GraphicsPath luftballongBilde, GraphicsPath smileyListe, GraphicsPath hinderListe, GraphicsPath kuleListe, PaintEventArgs e)
        {
            Region lb = new Region(luftballongBilde);
            Region sl = new Region(smileyListe);
            Region hl = new Region(hinderListe);
            Region kl = new Region(kuleListe);

            if (lb.Intersect(sl))

            
        }*/

        /// <summary>
        /// Kaller på invalidate metoden hvert 17 millisekund
        /// </summary>
        public void Run()
        {
            while (running)
            {
                this.Invalidate();
                Thread.Sleep(17);
            }
        }

        /// <summary>
        /// Starter tråd som spillet "kjører" i
        /// </summary>
        public void start()
        {
            running = true;
            timer.Enabled = true; 
            timer.Start(); //Starter timeren som styrer gravitasjonen
            ThreadStart ts = new ThreadStart(Run);
            Thread thread = new Thread(ts);
            thread.Start();
            thread.IsBackground = true;
        }

        /// <summary>
        /// Timer-tick metoden
        /// Senker ballongen sin høyde hvert "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {

            if (luftballong.y < this.Height - 65.5)  
            {
                luftballong.y += 1;
                Invalidate();
            }
        }


        /// <summary>
        /// Metode for bevegelse av luftballong
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (luftballong.x > 0)
                {
                    luftballong.x -= luftballong.bx;
                    this.Invalidate();
                }
            }
            else if (keyData == Keys.Right)
            {
                if (luftballong.x < this.Width - 32)
                {
                    luftballong.x += luftballong.bx;
                    this.Invalidate();
                }
            }
            else if (keyData == Keys.Up)
            {
                if (luftballong.y > 2)
                {
                    luftballong.y -= luftballong.by;
                    this.Invalidate();
                }
            }
            else if (keyData == Keys.Down)
            {
                if (luftballong.y < this.Height - 68)
                {
                    luftballong.y += luftballong.by;
                    this.Invalidate();
                }
            } 

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Poengsum
        // "Get"-metode, brukes til å skrive inn poengsummen i label
        public string GetPoints()
        {
            return "Poengsum: " + poengsum;
        }

        //Get metode for kun tallverdien til poengsummen
        public int GetPoengsum()
        {
            return poengsum;
        }
        #endregion
        
        public void Restart()
        {
            luftballongBilde.Location = new Point(luftballong.x + 10, luftballong.y + 10);
            poengsum = 0;
            Invalidate();
        }

        
    }
}
