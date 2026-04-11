using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int SecCounter = 0;
        int MinCounter = 0;
        int HourCounter = 0;

        private void Sec_Tick(object sender, EventArgs e)
        {
            if (SecCounter >= 59)
            {
                SecCounter = 0;
                labSec.Text = SecCounter.ToString();
            }
            else
            {
                SecCounter++;
                labSec.Text = SecCounter.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sec.Enabled = true;
            Min.Enabled = true;
            Hour.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sec.Enabled = false;
            Min.Enabled = false;
            Hour.Enabled = false;
           
        }

        private void Min_Tick(object sender, EventArgs e)
        {
            if (MinCounter >= 59)
            {
                MinCounter = 0;
                labMin.Text = MinCounter.ToString();
            }
            else
            {
                MinCounter++;
                labMin.Text = MinCounter.ToString();
            }
        }

        private void labHour_Click(object sender, EventArgs e)
        {
         
        }

        private void Hour_Tick(object sender, EventArgs e)
        {
            if (HourCounter >= 23)
            {
                HourCounter = 0;

                labHour.Text = HourCounter.ToString();
            }
            else
            {
                HourCounter++;
                labHour.Text = HourCounter.ToString();
            }
        }


    }
}
