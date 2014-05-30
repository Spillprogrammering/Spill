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
using Game.Forms;
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

        private List<Hinder> hinderListe = new List<Hinder>(); //Liste som tar vare på alle Hinder-objekter
        private List<Skytter> skytterListe = new List<Skytter>(); //Liste som tar vare på alle Skyttere
        private List<Smiley> smileyListe = new List<Smiley>(); //Liste som tar vare på alle smileyfjes

        private bool running = false; //Boolsk variabel som skal brukes til å sjekke om spillet kjører eller ikke
        private System.Windows.Forms.Timer timer; //timer brukt til gravitasjon
        Button btnStartSpill = new System.Windows.Forms.Button();
        private static int poengsum;
        private GraphicsPath luftBallongPath = new GraphicsPath();
        private int brettnummer = 1;
        private Level level;
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
            if (brettnummer == 1) { 
            
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
            
            }

            if (brettnummer == 2) { 
            //Level 2
            hinderListe.Add(new Hinder(150, 250, 300, 80, 1));
            hinderListe.Add(new Hinder(550, 250, 300, 80, 1));
            hinderListe.Add(new Hinder(10, 200, 200, 200, 2));
            hinderListe.Add(new Hinder(825, 200, 200, 200, 2));
            hinderListe.Add(new Hinder(460, 0, 80, 150, 1));
            hinderListe.Add(new Hinder(460, 425, 80, 250, 1));

            
            smileyListe.Add(new Smiley(420, 10, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(530, 10, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(420, 575, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(530, 580, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(480, 275, 50, 50, -60, -60, 3));
            smileyListe.Add(new Smiley(200, 500, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(700, 500, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(700, 100, 50, 50, -60, -60, 2));
            

            skytterListe.Add(new Skytter(300, 0, 80, 80, -70, -40));
            skytterListe.Add(new Skytter(600, 0, 80, 80, -70, -40));
            skytterListe.Add(new Skytter(300, 545, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(600, 545, 80, 80, 70, 40)); 

            }

            if (brettnummer == 3) { 
            // Level 3
            hinderListe.Add(new Hinder(220, 250, 250, 80, 1));
            hinderListe.Add(new Hinder(530, 250, 250, 80, 1));
            hinderListe.Add(new Hinder(460, 100, 80, 200, 1));
            hinderListe.Add(new Hinder(460, 275, 80, 200, 1));

            smileyListe.Add(new Smiley(390, 190, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(550, 190, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(390, 360, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(550, 360, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(475, 55, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(475, 500, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(160, 275, 50, 50, -60, -60, 3));
            smileyListe.Add(new Smiley(785, 275, 50, 50, -60, -60, 3));


            skytterListe.Add(new Skytter(80, 0, 80, 80, -70, -40));
            skytterListe.Add(new Skytter(135, 545, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(850, 0, 80, 80, -70, -40));
            skytterListe.Add(new Skytter(770, 545, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(0, 160, 80, 80, 160, 40));
            skytterListe.Add(new Skytter(955, 160, 80, 80, 340, 40));
            skytterListe.Add(new Skytter(0, 330, 80, 80, 160, 40));
            skytterListe.Add(new Skytter(955, 330, 80, 80, 340, 40));

            }


        }

     /*   public void tegnFigurer()
        {
            hinderListe.Add(new Hinder(300, 400, 80, 30, 1));
            hinderListe.Add(new Hinder(500, 400, 80, 30, 1));
            hinderListe.Add(new Hinder(300, 400, 30, 30, 2));
            hinderListe.Add(new Hinder(600, 400, 30, 30, 2));

            smileyListe.Add(new Smiley(170, 35, 50, 50, -60, -60, 1));

            skytterListe.Add(new Skytter(155, 430, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(610, 430, 80, 80, 70, 40));

        } */

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
                    int verdi = smileyListe[i].Verdi; //Finner verdien til diamanten

                    smileyListe.RemoveAt(i); // fjerner diamanten når kollisjonen inntreffer 
                    poengsum += verdi;
                    if (smileyListe.Count < 1)
                    {
                        Clear();
                    }

                }

                smiley.Draw(e.Graphics); //Kaller på tegne metoden for "Smileys"
            }
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
        // Rensker alt som er tegnet -Marcus
        public void Clear()
        {
            hinderListe.Clear();
            smileyListe.Clear();
            skytterListe.Clear();
            luftBallongPath.Reset();
            timer.Stop();
            brettnummer++;
            Restart();
            tegnFigurer();
            luftballongBilde.Location = new Point(10, 10); //Setter posisjonen til luftballongen
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

        #region Bevegelse av luftballong
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
        #endregion

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
