using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"E:\"; // to set the default dir for the dialog 
            openFileDialog1.DefaultExt = "png"; // to set the default file extension of dialog
            openFileDialog1.Title = "Open....."; // set the title for open dialog window
            openFileDialog1.Filter = "Png(*.png)|*.png|Jpg(*.jpg)|*.jpg"; // to set the file extension selections 

            // to select the default filter (it starts from 1 not 0 and
            // if you have set index larger than actual filter you have it will back to the last available index)
            openFileDialog1.FilterIndex = 3;

            openFileDialog1.FileName = "Photo.png";//to set the default opening file 

            //openFileDialog1.Multiselect = true; // to allow the user to selects more than one file to open 

            string[] AllowedExt = { ".png",".jpg"};


            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //To Avoid the user to select file with wrong extension (if you set the filter index to 3 it will show all files but you want to allow only png and jpg)
                if (AllowedExt.Contains(Path.GetExtension(openFileDialog1.FileName.ToLower()))) // to check if the file extension is in the allowed extensions array
                {
                    MessageBox.Show(openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                else
                    MessageBox.Show("Wrong Extension","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
