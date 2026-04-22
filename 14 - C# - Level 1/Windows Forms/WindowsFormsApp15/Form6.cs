using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            saveFileDialog1.DefaultExt = "text"; // to set the default file extension 
            saveFileDialog1.Title = "Hello World"; // to set the title of file save dialog 

            saveFileDialog1.Filter = "text(*.text)|*.text|png(*.png)|*.png|Sound(*.mp3)|*.mp3|All Files(*.*)|*.*"; // to set specific file filtering according to its type (text|*.fileExt)

            saveFileDialog1.FilterIndex = 100; // to select the default filter (it starts from 1 not 0 and if you have set index larger than actual filter you have it will back to the last available index)

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
                File.WriteAllText(saveFileDialog1.FileName, "Hello World!");
            }
        }
    }
}
