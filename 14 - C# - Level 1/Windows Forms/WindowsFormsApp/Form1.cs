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
            cbDisableAll.CheckState = CheckState.Unchecked; // change the statue from checked to unchecked 
            checkBox2.Enabled = true;
            checkBox1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.Green;
                radioButton2.BackColor = Color.Red;
            }
            else 
            {
                radioButton2.ForeColor = Color.CadetBlue;
                radioButton2.BackColor = Color.Blue;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbB1.AutoCheck = true; // turn on the ability to change the statue of check box again 
            btn1.BackColor = Color.Green; 
        }

        private void rbB1_CheckedChanged(object sender, EventArgs e)
        {
            rbB1.Text = "R1 Selected";
            rbB1.ForeColor = Color.AliceBlue;
            if (rbB1.Checked)
                MessageBox.Show("The Radio btn 1 is checked ");

            rbB1.BackColor = Color.AliceBlue; 


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Grb1btn2.ForeColor = Color.GreenYellow;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
            //

            MessageBox.Show("The Group Box 1 Has Entered");
            groupBox1.BackColor = Color.Black ;
            

        }

        private void Grb1btn1_CheckedChanged(object sender, EventArgs e)
        {
            Grb1btn1.ForeColor = Color.Green;
        }

        private void Grp1btn2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Grp1btn3_CheckedChanged(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
