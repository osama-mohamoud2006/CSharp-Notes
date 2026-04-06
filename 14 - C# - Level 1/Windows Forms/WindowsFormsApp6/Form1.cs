using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            maskedTextBox2.Focus();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox2.MaskFull || maskedTextBox2.MaskCompleted)
                MessageBox.Show(maskedTextBox2.Text);
            //if (maskedTextBox2.MaskFull)
            //{
            //    string[] str = maskedTextBox2.Text.Split('/');

            //    DateTime d = new DateTime(Convert.ToInt16(str[2]), Convert.ToInt16(str[1]), Convert.ToInt16(str[0]));

            //    MessageBox.Show(d.Year.ToString());
            //}
            // 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Focus();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(maskedTextBox3.MaskFull || maskedTextBox3.MaskCompleted)
            MessageBox.Show(maskedTextBox3.Text); 
        }
    }
}
