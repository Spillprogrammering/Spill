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
        private System.Windows.Forms.Timer timer;

        //Konstruktør for spillpanelet
        public levelSpillPanel()
        {
            //Fjerner "blinking" når spillet tegnes
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true); 
            this.UpdateStyles();

            //KeyEventHandler for knappene som skal styre luftballongen
            (this as Control).KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bevegelse_KeyDown);
           
            //Legg til hindere, skyttere og smilefjes i lister HUSK LAG METODE FOR Å LEGGE ALLE HINDERE/SKYTTERE/SMILEYS I LISTE. OBJEKTORIENTERT!!!!!

            hinderListe.Add(new Hinder(300, 260, 200, 200, 1));
            skytterListe.Add(new Skytter(new Point[] {new Point(120, 160), new Point(110,120), new Point(160,120)}));
            hinderListe.Add(new Hinder(90, 0, 20, 70, 3)); //Rektangel til høyre for ballongen
            hinderListe.Add(new Hinder(0, 130, 30, 20, 3)); //Rektangel nedenfor ballongen
            hinderListe.Add(new Hinder(100, 180, 150, 180, 1)); //Timeglasset
            hinderListe.Add(new Hinder(400, 500, 250, 40, 4));
            skytterListe.Add(new Skytter(new Point[] {new Point(10, 20), new Point(30,20), new Point(20,10) }));
            smileyListe.Add(new Smiley(222, 103, 50, 50, -60, -60, 1));
            smileyListe.Add(new Smiley(322, 203, 50, 50, -60, -60, 2));
            smileyListe.Add(new Smiley(422, 303, 50, 50, -60, 40, 3));

            //Timer til bevegelse
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
           
            //Legger til luftballongen
            luftballongBilde.Image = Game.Properties.Resources.luftbalong1;
            luftballongBilde.Size = new System.Drawing.Size(31, 65); //setter størrelsen på luftballong bildet
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

        
        private void timer_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Kaller på invalidate metoden
        /// </summary>
        public void Run()
        {
            while (true)
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
            ThreadStart ts = new ThreadStart(Run);
            Thread thread = new Thread(ts);
            thread.Start();
            thread.IsBackground = true;
        }

        // Styring for piltastene, og hvor kraftig de går i hver sin rettning
        public void Bevegelse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (luftballong.x > 0)
                {
                    luftballong.x -= luftballong.bx;
                    this.Invalidate();
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (luftballong.x < this.Width - 20)
                {
                    luftballong.x -= luftballong.bx;
                    this.Invalidate();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (luftballong.y > 5)
                {
                    luftballong.y -= luftballong.by;
                    this.Invalidate();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (luftballong.y < this.Height - 20)
                {
                    luftballong.y += luftballong.by;
                    this.Invalidate();
                }
            } 
        }





    }
}
