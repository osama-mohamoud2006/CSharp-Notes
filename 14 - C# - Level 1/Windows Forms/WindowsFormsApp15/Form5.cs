using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true; // to show the fore color option in font dialog 
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;

            fontDialog1.Font = label1.Font;

            DialogResult res = DialogResult.None;

            Font Temp = label1.Font;
            Color CTemp = label1.BackColor; 

            if ((res=fontDialog1.ShowDialog())== DialogResult.OK)
            {
                label1.Font = fontDialog1.Font; // change the font of label 
                label1.ForeColor = fontDialog1.Color; // change the label text color
            }
            else if (res == DialogResult.Cancel) // closing window is considering cancel 
            {
                // Default 
                label1.Font = Temp;
                label1.BackColor = CTemp;

            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            MessageBox.Show("APPLYING");
            label1.Font = fontDialog1.Font; // change the font of label 
            label1.ForeColor = fontDialog1.Color; // change the label text color
            
        }
    }
}
