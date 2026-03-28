using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.ThreeState = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    MessageBox.Show("Check Box Enabled");
            //    button1.Enabled = true;
            //}
            //else MessageBox.Show("UnChecked");  button1.Enabled = false;


            /*
             * Options :
             * checked
             * un checked 
             * intermediate
             */

            //if(checkBox1.CheckState == CheckState.Checked)
            //{
            //    MessageBox.Show("Checked");
            //}
            //else if(checkBox1.CheckState == CheckState.Unchecked)
            //{
            //    MessageBox.Show("UnChecked");
            //}
            //else if(checkBox1.CheckState == CheckState.Indeterminate) // by default it doesn't do any thing 
            //{
            //    button1.Enabled = true;
            //    MessageBox.Show("Intermediate");
            //}

            // (to enable intermediate) 

            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Checked");
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("UnChecked");
            }
            else 
            {
                button1.Enabled = true;
                MessageBox.Show("Intermediate");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Checked");
                checkBox2.Text = "Checked";
                checkBox2.ForeColor = Color.Blue;

               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox3.AutoCheck = true; // enable the ability to change the check box state 
            MessageBox.Show("The Check Box Have Enabled", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            checkBox3.CheckState = CheckState.Unchecked; // change the check box state to unchecked 

            MessageBox.Show("Checked", "", MessageBoxButtons.OK);
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Text = "Checked By CheckState"; // change the text of check box 
            checkBox3.Appearance = Appearance.Button;
            button3.Visible = checkBox3.Checked; // as it is unchecked , so the button will hide 
        }
    }
}
