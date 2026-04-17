using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class ErrorProvider : Form
    {
        public ErrorProvider()
        {
            InitializeComponent();
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false; 
        }

        private void ErrorProvider_FormClosed(object sender, FormClosedEventArgs e) // خلاص الفورم اتقفل 
        {
            //MessageBox.Show("Form is closed");
            //Exercise_on_emp_management temp = new Exercise_on_emp_management();
            //    temp.ShowDialog();
        }

        // this event is firing before the control loses its focus 
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (sender == sender as TextBox)
            {

                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    e.Cancel = true; // user can n't leave the text box
                    errorProvider1.SetError(textBox1, "Validating Was Failed"); // to make the error provider enabled 
                }
                else
                {
                    e.Cancel = false;// user can leave the text box 
                    errorProvider1.SetError(textBox1, ""); // to disable the error provider  

                }

            }

            else if (sender == sender as MaskedTextBox)
            {
                if (!maskedTextBox1.MaskCompleted)
                {
                    e.Cancel = true; // prevent the user from escaping the control
                    errorProvider1.SetError(maskedTextBox1, "Make Isn't Filled With Required Fields!");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(maskedTextBox1, "");
                }
            }

            else if (sender == sender as RichTextBox)
            {
                if (String.IsNullOrEmpty(richTextBox1.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(richTextBox1, "Empty Or Null!");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(richTextBox1, "");
                }
            }


       
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true; // prevent user from closiong the form or escape the control 
                errorProvider1.SetError(textBox1, "You cann't Use The button before filling the text box");
                errorProvider1.SetError(button1, "You cann't Use The button before filling the text box");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
                errorProvider1.SetError(button1, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
