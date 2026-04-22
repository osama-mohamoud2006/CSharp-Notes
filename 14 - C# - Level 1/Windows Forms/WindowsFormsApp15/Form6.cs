using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"E:\"; // to make the file save dialog starts with specific dir 
            saveFileDialog1.DefaultExt = "png"; // to set the default file extension 
            saveFileDialog1.Title = "Hello World"; // to set the title of file save dialog 

            saveFileDialog1.Filter = "text(*.text)|*.text|png(*.png)|*.png"; // to set specific file filtering according to its type (text|*.fileExt)

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }
    }
}
