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
        stTime Time;
       

        void UpdateTimeLabel(Label NameOfLabel , int value)
        {
            NameOfLabel.Text = value.ToString();
        }

        // Timer To Decrement Until Reaches 0 
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void UpDownHour_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
