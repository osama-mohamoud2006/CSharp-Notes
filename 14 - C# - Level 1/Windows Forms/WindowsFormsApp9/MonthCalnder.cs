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
    public partial class MonthCalnder : Form
    {
        public MonthCalnder()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            label1.Text = "Start Date: " +Environment.NewLine +monthCalendar1.SelectionStart.ToString("d/MM/yyy");
            label2.Text = "End Date: " + Environment.NewLine + monthCalendar1.SelectionEnd.ToString("d/MM/yyy");
        }

        private void MonthCalnder_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar1.MaxDate = DateTime.Now.AddDays(30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1
        }
    }
}
