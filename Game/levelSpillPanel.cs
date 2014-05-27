using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Game
{
    class levelSpillPanel : Panel
    {
        private Luftballong luftballong = new Luftballong(10,10,2,3); //Luftballong
        private PictureBox luftballongBilde = new PictureBox();
        private List<Hinder> hinderListe = new List<Hinder>(); //Liste som tar vare på alle Hinder-objekter
        private List<Skytter> skytterListe = new List<Skytter>(); //Liste som tar vare på alle Skyttere
        private List<Smiley> smileyListe = new List<Smiley>(); //Liste som tar vare på alle smileyfjes
        private bool running = false; //Boolsk variabel som skal brukes til å sjekke om spillet kjører eller ikke
        private System.Windows.Forms.Timer timer; //timer brukt til bevegelse

        //Konstruktør for spillpanelet
        public levelSpillPanel()
        {
            //Fjerner "blinking" når spillet tegnes
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true); 
            this.UpdateStyles();

            //Legg til hindere, skyttere og smilefjes i lister HUSK LAG METODE FOR Å LEGGE ALLE HINDERE/SKYTTERE/SMILEYS I LISTE. OBJEKTORIENTERT!!!!!
            hinderListe.Add(new Hinder(300, 260, 200, 200));
            hinderListe.Add(new Hinder(500, 300, 30, 50, 1));
            hinderListe.Add(new Hinder(700, 250, 30, 50, 2));

            //skytterListe.Add(new Skytter(new Point[] {new Point(120, 160), new Point(110,120), new Point(160,120)}));
            //skytterListe.Add(new Skytter(new Point[] {new Point(10, 20), new Point(30,20), new Point(20,10) }));
            skytterListe.Add(new Skytter(600, 400, 80, 80, 70, 40));
            smileyListe.Add(new Smiley(222, 103, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(322, 203, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(422, 303, 50, 50, -60, -60, 3));

            //Timer til bevegelse
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
           
            //Legger til luftballongen
            luftballongBilde.Image = Game.Properties.Resources.luftbalong1;
            luftballongBilde.Size = new System.Drawing.Size(31, 60); //setter størrelsen på luftballong bildet
            this.Controls.Add(luftballongBilde);
            
            //Starter spillet FLYTTES INN UNDER ONCLICK TIL KNAPPEN SENERE
            start();

        }

        /// <summary>
        /// Overstyrer OnPaint metoden
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); //videresender til onpaint superklassen
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Setter høy kvalitet på kantene til objektene

            luftballongBilde.Location = new Point(luftballong.x, luftballong.y); //Setter posisjonen til luftballongen

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
                smiley.Draw(e.Graphics);
            }
        }

        /// <summary>
        /// Timer-tick metoden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (luftballong.y < this.Height - 20)
            {
                luftballong.y += 2;
                Invalidate();
            }
        }

        /// <summary>
        /// Kaller på invalidate metoden
        /// </summary>
        public void Run()
        {
            while (true)
            {
                this.timer.Enabled = true; //starter timeren som blir brukt til bevegelse
                this.Invalidate();
                Thread.Sleep(17);
            }
        }

        /// <summary>
        /// Starter tråd som spillet kjører i
        /// </summary>
        public void start()
        {
            ThreadStart ts = new ThreadStart(Run);
            Thread thread = new Thread(ts);
            thread.Start();
            thread.IsBackground = true;
        }

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
                if (luftballong.x < this.Width - 20)
                {
                    luftballong.x += luftballong.bx;
                    this.Invalidate();
                }
            }
            else if (keyData == Keys.Up)
            {
                if (luftballong.y > 5)
                {
                    luftballong.y -= luftballong.by;
                    this.Invalidate();
                }
            }
            else if (keyData == Keys.Down)
            {
                if (luftballong.y < this.Height - 20)
                {
                    luftballong.y += luftballong.by;
                    this.Invalidate();
                }
            } 

            return base.ProcessCmdKey(ref msg, keyData);
        }





    }
}
