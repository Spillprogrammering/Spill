using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class FormView : Form
    {
        SpillPanel s = null;
        Login loginRef;

        public FormView(Login _loginRef)
        {
            InitializeComponent();
            this.loginRef = _loginRef;

            s = new SpillPanel();
            
            this.Controls.Add(s);

            //s.Focus();
        }

        public FormView()
        {
            // TODO: Complete member initialization
        }


       /* private void FormView_Paint_1(object sender, PaintEventArgs e)
        {
            
        } */

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
         
        

        private void FormView_Load(object sender, EventArgs e)
        {

        }

       /* private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        } */

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            s.Bevegelse_KeyDown(sender, e);
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginRef.Close();
        }


    }
}
