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

        private void ErrorProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            //var res = MessageBox.Show("Are you sure you want to close the form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if(res == DialogResult.Yes)
            //{
            //    this.Hide();
            //}

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
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true; // user can n't leave the text box
                errorProvider1.SetError(textBox1, "Validating Was Failed");
            }
            else
            {
                e.Cancel = false;// user can leave the text box 
            }

        }

     


    }
}
