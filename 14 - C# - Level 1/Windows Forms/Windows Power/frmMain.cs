using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Windows_Power.frmTimer;

namespace Windows_Power
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

           
        }

        frmTimer Timer = new frmTimer(); // Timer Form 
    
    

        private void pbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program Is Made To Manage Your Computer Power State\n" +
                " By Set Timer With Specific Time To Change its State According To Your Choice!", "Info");
        }


        public enum enPowerState :byte{ enShutDown=1,enReboot=2 , enSleep=3 }

        enPowerState PowerState;
       
        private void SetPowerState(string SelectedOption)
        {
           
           switch(SelectedOption.ToLower())
            {
                case "shutdown":
                    PowerState = enPowerState.enShutDown;
                    break;

                case "reboot":
                    PowerState = enPowerState.enReboot;
                    break;

                case "sleep":
                    PowerState = enPowerState.enSleep;
                    break;
            }

        }

        private void EnableScreenComp()
        {
            labMin.Enabled = true;
            labSec.Enabled = true;
            labHour.Enabled = true;
            btnSetTimer.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

            SetPowerState(cb.SelectedItem.ToString());

            EnableScreenComp(); // To Enable set timer Control 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Wheat;
        }

        private void CallTimerFormButton_Click(object sender, EventArgs e)
        {
            
            Timer.ShowDialog();

            btnStop.Visible = true;
            btnSetTimer.Enabled = false;
            timer1.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Timer.TimerStop();
            btnStop.Visible = false;
            timer1.Enabled = false;
            btnSetTimer.Enabled = true;
        }

        // Sorry for dirty code but in my level this is the best I can do :D (this timer handles the timer in both 2 forms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer.TheTimeOfTimer.Sec == 0 && Timer.TheTimeOfTimer.Min == 0 && Timer.TheTimeOfTimer.Hour == 0)
            {
                timer1.Enabled = false;

                Timer.UpDownHour.Enabled = true;
                Timer.UpDownMin.Enabled = true;
                Timer.UpDownSec.Enabled = true;

                Timer.RestUpDown();

                Timer.labTSec.Text = "0";
                Timer.labTMin.Text = "0";
                Timer.labTHour.Text = "0";

                this.labHour.Text = "0";    
                this.labMin.Text = "0";
                this.labSec.Text = "0";

               

                return;
            }



            if (Timer.TheTimeOfTimer.Min == 0 && Timer.TheTimeOfTimer.Hour != 0 && Timer.TheTimeOfTimer.Sec == 0)
            {
                Timer.TheTimeOfTimer.Min = 59;
                Timer.TheTimeOfTimer.Sec = 59;

               

                Timer.TheTimeOfTimer.Hour--;

                Timer.UpdateTimeLabel(Timer.labTHour, Timer.TheTimeOfTimer.Hour);
                Timer.UpdateTimeLabel(Timer.labTMin, Timer.TheTimeOfTimer.Min);
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec);

                this.labHour.Text = Timer.TheTimeOfTimer.Hour.ToString();
                this.labMin.Text = Timer.TheTimeOfTimer.Min.ToString();
                this.labHour.Text = Timer.TheTimeOfTimer.Hour.ToString();


                return;
            }


            if (Timer.TheTimeOfTimer.Sec != 0)
            {
                Timer.TheTimeOfTimer.Sec--; // decrement the seconds 
                this.labSec.Text = Timer.TheTimeOfTimer.Sec.ToString();
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec); // update the label

            }
            else  // 60 Sec Has Passed 
            {

                if (Timer.TheTimeOfTimer.Min != 0) Timer.TheTimeOfTimer.Min--;

                Timer.TheTimeOfTimer.Sec = 59;
                this.labSec.Text = Timer.TheTimeOfTimer.Sec.ToString();
                this.labMin.Text = Timer.TheTimeOfTimer.Min.ToString();
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec); // update the label --> 59 
                Timer.UpdateTimeLabel(Timer.labTMin, Timer.TheTimeOfTimer.Min); // update the label 
            }

            // 1 Min = 60000 Ms = 60 Sec
        }


    }
}
