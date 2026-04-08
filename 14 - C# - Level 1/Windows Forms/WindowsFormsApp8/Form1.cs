using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");

            if (linkLabel1.LinkVisited)
                MessageBox.Show("You have visited the link");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = false; 
        }
    }
}
