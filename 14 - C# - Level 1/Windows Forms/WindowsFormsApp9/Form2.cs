using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; // get the date and time of now (local time) 
            dateTimePicker2.Value = dt; // set the value for the control 
            label1.Text =dt.Hour.ToString() + "/"+dt.Minute.ToString()+"/"+dt.Second.ToString();
            dateTimePicker2.MinDate = dt; // set the min value of date the current day (make the min value is the today)
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //Environment.NewLine --> works like "\n"
            label2.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy")+Environment.NewLine
             + dateTimePicker2.Value.ToString("h-mmm-s");
                
        }
    }
}
