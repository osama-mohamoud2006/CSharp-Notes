using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox2.Checked.ToString(), "Checked The Box2");

            _ = (checkBox2.Checked) ? true : false; // checked->  true otherwise false 

            if (checkBox2.CheckState == CheckState.Checked)
            {// to do
                checkBox2.Text = "Checked";
                checkBox2.ForeColor = Color.PaleGoldenrod;
            }


            else if (checkBox2.CheckState == CheckState.Unchecked)
            {// to do
               
            }




            else if  (checkBox2.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Intermediate");
            }
              
            


        }

        private void cbDisableAll_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDisableAll.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;

                cbDisableAll.AutoCheck = false; // make the change of the check box state unenabled 
            }
        }

        private void cbEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            cbDisableAll.AutoCheck = true; // make the change of the check box state enabled 

        }
    }
}
