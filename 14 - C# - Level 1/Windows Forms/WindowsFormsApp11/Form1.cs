using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Text = "test notfi";
            notifyIcon1.Icon = new Icon(@"C:\\Users\\wwwhd\\Downloads\\black-cat.ico"); // icon that next to the notification title 
            notifyIcon1.BalloonTipTitle = "Test Notification title"; // title of notification 
            notifyIcon1.BalloonTipText = "Hello world this is text!"; // the text ``````````

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
           

            notifyIcon1.ShowBalloonTip(30000); // time in Ms

        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            //MessageBox.Show("Has Shown");
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
          
            MessageBox.Show("Clicked");
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Notification Closed");
        }

        private void notifyIcon1_BalloonTipShown_1(object sender, EventArgs e)
        {
            MessageBox.Show("The Notification Apperaed!");
        }
    }
}
