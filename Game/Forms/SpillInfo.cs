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
    /// <summary>
    /// Klasse for SpillInfo formen
    /// Her står det info om spillet, for eksempel hva Smiley'ene er verdt
    /// @Author Marcus
    /// </summary>
    public partial class SpillInfo : Form
    {

        public SpillInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //gjør slik at du ikke kan justere på størrelsen
            this.StartPosition = FormStartPosition.CenterScreen; //Setter startposisjonen på formen til å være midt på skjermen
        }

        private void btnlukk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SpillInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
