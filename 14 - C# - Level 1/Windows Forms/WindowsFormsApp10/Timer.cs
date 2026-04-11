using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp10
{
    public partial class Timer : Form
    {
       

        public Timer()
        {
            InitializeComponent();
        }

     
        struct stTime
        {
            public int Hour;
            public int Min ;
            public int Sec; 
        }
        stTime Time; // the time assigned by user 

        int PassedTime = 0; 

        void UpdateTimeLabel(Label NameOfLabel , int value)
        {
            NameOfLabel.Text = value.ToString();
        }


        private void RestUpDown()
        {
            UpDownHour.Value = 0;
            UpDownMin.Value = 0;
            UpDownSec.Value = 0;
        }

        // Timer To Decrement Until Reaches 0 
        // this event is firing each 1 sec by timer control 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time.Sec == 0 && Time.Min == 0 && Time.Hour == 0)
            {
                timer1.Enabled = false;
                RestUpDown();
                labSec.Text = "0";
                MessageBox.Show("Your Timer Has Finished ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            if(Time.Min==59)
            {
                Time.Hour--;
                UpdateTimeLabel(labHour, Time.Hour);

            }

            if(Time.Min==0 && Time.Hour!=0)
            {
                Time.Hour--;
                Time.Min = 59; 
                UpdateTimeLabel(labHour, Time.Hour);
            }
          

            if (Time.Sec != 0)
            {
               
                UpdateTimeLabel(labSec, Time.Sec); // update the label
                Time.Sec--; // decrement the seconds 
            }
            else // 60 Sec Has Passed 
            {
            
            if (Time.Min!=0) Time.Min--;
             

                Time.Sec = 59;
                UpdateTimeLabel(labMin, Time.Sec); // update the label --> 59 
                UpdateTimeLabel(labMin, Time.Min); // update the label 
                Time.Sec--;
            }

            // 1 Min = 60000 Ms = 60 Sec

            PassedTime++; // 1m = 60 
            if(PassedTime>=3600) // 1h has passed
            {
                Time.Hour--;
                UpdateTimeLabel(labHour, Time.Hour);

            }

        }


        private void SetTimer(string UpDownCounter , int value )
        {
            switch(UpDownCounter)
            {
                case "Hour":
                    UpdateTimeLabel(labHour, value); // update the label
                    Time.Hour = value;
                    break;


                case "Min":
                    UpdateTimeLabel(labMin, value); // update the label
                    Time.Min = value;
                    break;

                case "Sec":
                    UpdateTimeLabel(labSec, value); // update the label
                    Time.Sec = value;
                    break;


            }
        }


        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown ud = sender as NumericUpDown;
            SetTimer(ud.Tag.ToString(), Convert.ToInt32(ud.Value) );
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Time.Sec == 0 && Time.Min == 0 && Time.Hour == 0)
            {
                MessageBox.Show("Timer Cannot Start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                timer1.Enabled = true;
                
            }

        }

        private void HourTimer_Tick(object sender, EventArgs e)
        {
          

        }
    }
}
