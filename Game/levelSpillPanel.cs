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

namespace Game
{
    class levelSpillPanel : Panel
    {
        private Luftballong luftballong = new Luftballong(10,10,2,3); //Luftballong
        private PictureBox luftballongBilde = new PictureBox();
        private SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.gatherGemSound); //Lyd når du plukker opp samleobjekt (diamant)
        private List<Hinder> hinderListe = new List<Hinder>(); //Liste som tar vare på alle Hinder-objekter
        private List<Skytter> skytterListe = new List<Skytter>(); //Liste som tar vare på alle Skyttere
        private List<Smiley> smileyListe = new List<Smiley>(); //Liste som tar vare på alle smileyfjes
        private bool running = false; //Boolsk variabel som skal brukes til å sjekke om spillet kjører eller ikke
        private System.Windows.Forms.Timer timer; //timer brukt til gravitasjon
        Button btnStartSpill = new System.Windows.Forms.Button();

        private GraphicsPath luftBallongPath = new GraphicsPath();
        

        //Konstruktør for spillpanelet
        public levelSpillPanel()
        {
            //Fjerner "blinking" når spillet tegnes
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true); 
            this.UpdateStyles();

            tegnFigurer();

            //Timer til gravitasjon
            timer = new System.Windows.Forms.Timer(); //Oppretter timer
            timer.Interval = 20; //Setter intervallet mellom hvert "tick"
            timer.Tick += new EventHandler(timer_Tick);

            timer.Enabled = true;
            timer.Start();

            //timer.Enabled = false;

            //timer.Stop();

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
            //Legg til hindere, skyttere og smilefjes i lister HUSK LAG METODE FOR Å LEGGE ALLE HINDERE/SKYTTERE/SMILEYS I LISTE. OBJEKTORIENTERT!!!!!
            hinderListe.Add(new Hinder(120, 0, 20, 100, 1)); //rektangel til høyre for ballongen
            hinderListe.Add(new Hinder(0, 160, 20, 10, 1)); //rektangel under ballongen
            hinderListe.Add(new Hinder(240, 0, 20, 100, 1)); //rektangel nr. 2 til høyre for ballongen
            hinderListe.Add(new Hinder(175, 250, 30, 30, 2)); //sirkelen
            hinderListe.Add(new Hinder(300, 250, 400, 250)); //Funky figur
            hinderListe.Add(new Hinder(620, 30, 50, 50, 2)); //sirkelen oppi høyre hjørnet

            smileyListe.Add(new Smiley(170, 35, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(75, 250, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(318, 220, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(30, 450, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(500, 100, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(632, 270, 50, 50, -60, -60, 3));

            //skytterListe.Add(new Skytter(new Point[] {new Point(120, 160), new Point(110,120), new Point(160,120)}));
            //skytterListe.Add(new Skytter(new Point[] {new Point(10, 20), new Point(30,20), new Point(20,10) }));
            skytterListe.Add(new Skytter(155, 430, 80, 80, 70, 40));
            skytterListe.Add(new Skytter(610, 430, 80, 80, 70, 40));
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
            
            Rectangle rec = new Rectangle(luftballong.x - 50, luftballong.y, 1, 1); // Setter størrelsen på rektangelet i diamantene
            luftBallongPath.StartFigure();
            luftBallongPath.AddRectangle(rec);
            luftBallongPath.CloseFigure();

            //Går igjennom listene med objekter og tegner dem
            for (int i = 0; i < hinderListe.Count; i++) 
            {
                Hinder hinder = hinderListe[i];
                hinder.Draw(e.Graphics);
            }
            for (int i = 0; i < skytterListe.Count; i++)
            {
                Skytter skytter = skytterListe[i];
                skytter.Draw(e.Graphics);
            }
            for (int i = 0; i < smileyListe.Count; i++)
            {
                Smiley smiley = smileyListe[i];

                if (checkcollision(luftBallongPath, smiley.getPath(), e))
                {
                    smileyListe.RemoveAt(i); // fjerner diamanten når kollisjonen inntreffer 
                }
                
                smiley.Draw(e.Graphics);
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

        /// <summary>
        /// Kaller på invalidate metoden
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
        /// Starter tråd som spillet kjører i
        /// </summary>
        public void start()
        {
            
            running = true;
            timer.Enabled = true;
            timer.Start();
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
    }
}
