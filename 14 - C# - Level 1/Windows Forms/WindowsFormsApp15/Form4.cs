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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.BackColor = colorDialog1.Color;
                this.textBox2.BackColor = colorDialog1.Color;
                this.textBox3.BackColor = colorDialog1.Color;
                this.textBox4.BackColor = colorDialog1.Color;
            }
        }
    }
}
