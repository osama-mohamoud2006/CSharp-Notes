using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form /// Form (super class) 
    {
        public MainForm()
        {
            InitializeComponent();
            //label1.BackColor = Color.Transparent;
            //btnStartForm1.BackColor = Color.Transparent; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
           

        }

        private void btnStartForm1_Click(object sender, EventArgs e)
        {
            Form1 NForm = new Form1(); // create instance of Form1(derived class) 

           // NForm.Show();
            NForm.ShowDialog();

            //MessageBox.Show("The Showing Has Finished And This Message Is A Confirmation That Complier Implemented The Second Line");

            this.Hide();
        }


    }
}
