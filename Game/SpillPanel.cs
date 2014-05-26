using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game
{
    public class SpillPanel : Panel 
    {
        private int x;
        private int y;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components = null;
        private Rectangle r = new Rectangle(10, 10, 30, 30);
        int[] fig1 = new int[] { 100, 200, 30, 40 };
        int[] fig2 = new int[] { 60, 150, 40, 20 };
        int[] fig3 = new int[] { 30, 200, 70, 65 };
        int[] fig4 = new int[] { 200, 300, 50, 80 };
        List<int[]> mylist = new List<int[]>();
        Image[] images = new Image[1];
        private Image brikke;
        Graphics g;
        Button btnStart = new Button();
        
        


        public SpillPanel()
        {
            
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Size = new System.Drawing.Size(800, 600);
            (this as Control).KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bevegelse_KeyDown);
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.tegn_Paint);
         

            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new Point(300,200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new Size(228, 128);
            this.btnStart.Image = Game.Properties.Resources.Skystart;
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.Controls.Add(this.btnStart);
        }

        public void Restart()
        {
            
            x = 100;
            y = 100;


            mylist.Add(fig1);
            mylist.Add(fig2);
            mylist.Add(fig3);
            mylist.Add(fig4);
            
            this.timer1.Enabled = true; 
            btnStart.Visible = false;
            
            //btnStart.Visible = true;


        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //this.btnStart.Image = Image.FromFile(Application.StartupPath + @"\skystart.png");

            Restart();
            
                       
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < this.Height - 20)
            {
                if (!hindring(2))
                {
                    y += 2;
                    Invalidate();
                }
            }
            
        }
        private void FormView_Load(object sender, EventArgs e)
        {
            //  g = tegn.CreateGraphics();

        }
        private void tegn_Paint(object sender, PaintEventArgs e)
        {
           // brikke = Image.FromFile(Application.StartupPath + @"luftbalong.png");
            brikke =  Game.Properties.Resources.luftbalong;
            //e.Graphics.FillEllipse(Brushes.Yellow, x, y, 20, 20);
            // g = .CreateGraphics();
            e.Graphics.FillPie(Brushes.Purple, 150, 150, 30, 50, 50, 50);
            e.Graphics.DrawImage(brikke, x, y, 30, 30);
            e.Graphics.FillRectangle(Brushes.Black, fig1[0], fig1[1], fig1[2], fig1[3]);
            e.Graphics.FillRectangle(Brushes.Black, fig2[0], fig2[1], fig2[2], fig2[3]);
            e.Graphics.FillRectangle(Brushes.Black, fig3[0], fig3[1], fig3[2], fig3[3]);
            e.Graphics.FillRectangle(Brushes.Black, fig4[0], fig4[1], fig4[2], fig4[3]);

            
          //  e.Graphics.DrawIcon(new Icon("C:\\Users\\Marcus\\Documents\\Visual Studio 2012\\Projects\\Game\\Game\\action.ico"), r);
        }

        private Boolean hindring(int e1)
        {
            if (e1 == 0) // venstre knapp 
            {
                for (int teller = 0; teller < 4; teller++)
                {
                    int[] localfig = mylist[teller];
                    if (!(localfig[1] > y + 30 || y > localfig[3] + localfig[1]))
                    {
                        if (!(localfig[0] > x))
                        {
                            if (localfig[0] + localfig[2] == x || localfig[0] + localfig[2] == x + 1)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else if (e1 == 1) // høyre knapp
            {
                for (int teller = 0; teller < 4; teller++)
                {
                    int[] localfig = mylist[teller];
                    if (!(localfig[1] > y + 30 || y > localfig[3] + localfig[1]))
                    {
                        //  if (!(localfig[0] < x))
                        {
                            if (localfig[0] == x + 30 || localfig[0] == x + 19)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else if (e1 == 2) // ned 
            {
                for (int teller = 0; teller < 4; teller++)
                {
                    int[] localfig = mylist[teller];
                    if (!(localfig[0] > x + 30 || x > localfig[2] + localfig[0]))
                    {
                        if (!(localfig[1] < y))
                        {
                            if (localfig[1] == y + 30 || localfig[1] == y + 19)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else if (e1 == 3) // opp
            {
                for (int teller = 0; teller < 4; teller++)
                {
                    int[] localfig = mylist[teller];
                    if (!(localfig[0] > x + 30 || x > localfig[2] + localfig[0]))
                    {
                        if (!(localfig[1] > y))
                        {
                            if (localfig[1] + localfig[3] == y
                                || localfig[1] + localfig[3] == y - 1
                                || localfig[1] + localfig[3] == y + 1
                                || localfig[1] + localfig[3] == y - 2
                                || localfig[1] + localfig[3] == y - 3
                                || localfig[1] + localfig[3] == y + 2
                                || localfig[1] + localfig[3] == y + 3
                                || localfig[1] + localfig[3] == y + 4

                                )
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        // Styring for piltastene, og hvor kraftig de går i hver sin rettning
        public void Bevegelse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (x > 0)
                {
                    if (!hindring(0))
                    {
                        x -= 2;
                        Invalidate();
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (x < this.Width - 20)
                {
                    if (!hindring(1))
                    {
                        x += 2;
                        Invalidate();
                    }

                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (y > 5)
                {
                    if (!hindring(3))
                    {
                        y -= 6;
                        Invalidate();
                    }

                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (y < this.Height - 20)
                {
                    if (!hindring(2))
                    {
                        y += 2;
                        Invalidate();
                    }

                    

                }
            }
        }
    }
}
