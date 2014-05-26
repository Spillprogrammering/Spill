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
    public partial class Level : Form 
    {
        levelSpillPanel level1Panel = null;

        public Level()
        {
            InitializeComponent();
            level1Panel = new levelSpillPanel();
            this.Controls.Add(level1Panel);
        }

        

    }
}
