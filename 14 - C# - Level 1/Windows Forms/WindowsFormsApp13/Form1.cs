using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0; 
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Enabled = true; 

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.BackColor = Color.Violet; 
            MessageBox.Show("Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
          
            for (int i = 1; i<= 10; i++ )
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                   Thread.Sleep(1000);
                    progressBar1.Value += 10;
                    
                    label1.Text = ((((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString()) + "%";
                    progressBar1.Refresh();
                    label1.Refresh();

                   
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                label1.Text = ((((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString()) + "%";

            }
            else timer1.Enabled = false;
        }
    }
}
