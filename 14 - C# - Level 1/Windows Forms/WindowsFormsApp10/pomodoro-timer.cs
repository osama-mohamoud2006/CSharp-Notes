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
    public partial class pomodoro_timer : Form
    {
        public pomodoro_timer()
        {
            InitializeComponent();
        }


        int MinCounter = 0; 
        int SecCounter = 0; 
         
        private bool MinPassed(int timeInterval)
        {
            return (timeInterval == 59) ? true : false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Each 1000ms this event is firing by timer control 
            // 1000ms = 1 sec 

            SecCounter++; // Second
            labSec.Text = SecCounter.ToString();



            if (MinPassed(SecCounter)) // after 60000 ms = 1 min passed 
            {
                MinCounter++;
                labMin.Text = MinCounter.ToString();

            }

            if (SecCounter >= 59) SecCounter = 0; // sec can n't exceed 59
            CheckIfTimerFinished();
        }

        void CheckIfTimerFinished()
        {
            if(MinCounter==25)
            {
                timer1.Enabled = false;
                MessageBox.Show("The Focus Session Has Finished","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinCounter = 0; SecCounter = 0;

            labSec.Text = SecCounter.ToString();
            labMin.Text = MinCounter.ToString();

            timer1.Enabled = true; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
