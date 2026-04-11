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

namespace Windows_Power
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

            labMin.Enabled = true;
            labSec.Enabled = true;
            labHour.Enabled = true;
            btnSetTimer.Enabled = true;

            SetPowerState(cb.SelectedItem.ToString());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Wheat;
        }

        private void CallTimerFormButton_Click(object sender, EventArgs e)
        {
            frmTimer Timer = new frmTimer();
            Timer.ShowDialog();
        }
    }
}
