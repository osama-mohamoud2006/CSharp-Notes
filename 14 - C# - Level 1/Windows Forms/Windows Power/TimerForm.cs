using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Power
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

       public struct stTime
        {
            public int Hour;
            public int Min;
            public int Sec;
        }

        stTime Time; // the time assigned by user 

        //int PassedTime = 0; 

        public frmMain ObjfrmMain; // reference to the main form to update its label

        private void UpdateMainFormLabel(Label NameOfLabel, int value)
        {
            switch(NameOfLabel.Tag.ToString())
            {
                case "labHour":
                    ObjfrmMain.labHour.Text = NameOfLabel.Text;
                    break;

                    case "labMin":
                    ObjfrmMain.labMin.Text = NameOfLabel.Text;
                    break;

                    case "labSec":
                     ObjfrmMain.labSec.Text = NameOfLabel.Text;
                    break;
            }
        }

        private void UpdateTimeLabel(Label NameOfLabel, int value)
        {
            NameOfLabel.Text = value.ToString();
            UpdateMainFormLabel(NameOfLabel, value) ;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time.Sec == 0 && Time.Min == 0 && Time.Hour == 0)
            {
                timer1.Enabled = false;
             
                UpDownHour.Enabled = true;
                UpDownMin.Enabled = true;
                UpDownSec.Enabled = true;
                RestUpDown();
                labSec.Text = "0";
                labMin.Text = "0";
                labHour.Text = "0";

                MessageBox.Show("Your Timer Has Finished ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }



            if (Time.Min == 0 && Time.Hour != 0 && Time.Sec == 0)
            {
                Time.Min = 59;
                Time.Sec = 59;
                Time.Hour--;

                UpdateTimeLabel(labHour, Time.Hour);
                UpdateTimeLabel(labMin, Time.Min);
                UpdateTimeLabel(labSec, Time.Sec);

                return;
            }


            if (Time.Sec != 0)
            {
                Time.Sec--; // decrement the seconds 
                UpdateTimeLabel(labSec, Time.Sec); // update the label

            }
            else  // 60 Sec Has Passed 
            {

                if (Time.Min != 0) Time.Min--;

                Time.Sec = 59;

                UpdateTimeLabel(labSec, Time.Sec); // update the label --> 59 
                UpdateTimeLabel(labMin, Time.Min); // update the label 
            }

            // 1 Min = 60000 Ms = 60 Sec



        }



        private void RestUpDown()
        {
            UpDownHour.Value = 0;
            UpDownMin.Value = 0;
            UpDownSec.Value = 0;
        }

        private void SetTimer(string UpDownCounter, int value)
        {
            switch (UpDownCounter)
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
            SetTimer(ud.Tag.ToString(), Convert.ToInt32(ud.Value));
        }

        // the start of Timer 
        public void Start()
        {
            if (Time.Sec == 0 && Time.Min == 0 && Time.Hour == 0)
            {
                MessageBox.Show("Timer Cannot Start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpDownHour.Enabled = true;
                UpDownMin.Enabled = true;
                UpDownSec.Enabled = true;

            }
            else
            {
               // timer1.Enabled = true;
               // UpDownHour.Enabled = false;
                //UpDownMin.Enabled = false;
                //UpDownSec.Enabled = false;
          
                //btnStop.Enabled = true;

            }

        }
        public void TimerStop()
        {
            timer1.Enabled = false;
          
            //btnStop.Enabled = false;
        }

        public void RestTimer()
        {
            
            RestUpDown();
            Time.Hour = 0;
            Time.Min = 0;
            Time.Sec = 0;
            //btnStop.Enabled = false;
         
            UpdateTimeLabel(labHour, 0); // update the label
            UpdateTimeLabel(labMin, 0); // update the label
            UpdateTimeLabel(labSec, 0); // update the label

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Start(); // start the timer 
            this.Hide();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestTimer();
        }


    }
}
