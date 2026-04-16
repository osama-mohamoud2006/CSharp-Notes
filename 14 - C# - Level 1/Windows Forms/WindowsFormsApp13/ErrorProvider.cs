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
            //DialogResult result = MessageBox.Show("متأكد عايز تقفل؟", "Confirm", MessageBoxButtons.YesNo);

            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true; // يمنع القفل
            //}
        }

        private void ErrorProvider_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  MessageBox.Show("Form is closed");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
