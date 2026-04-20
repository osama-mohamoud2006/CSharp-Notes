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


            DialogResult res = DialogResult.None; 
            if ((res=fontDialog1.ShowDialog())== DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
