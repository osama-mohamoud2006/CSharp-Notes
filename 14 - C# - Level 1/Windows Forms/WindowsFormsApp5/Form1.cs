using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            fuiTextBox1.Focus();
        }

        private void fuiButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void fuiButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true; 
        }

        private void fuiButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.ReadOnly = false;
        }

        private void fuiButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.RightToLeft = RightToLeft.No;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            button2.Focus();


        }
    }
}
