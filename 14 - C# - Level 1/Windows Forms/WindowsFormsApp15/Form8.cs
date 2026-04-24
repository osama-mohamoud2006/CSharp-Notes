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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to set the description that appears to user when he opens the dialog 
            folderBrowserDialog1.Description = "Hello Description !";

            folderBrowserDialog1.RootFolder= Environment.SpecialFolder.MyComputer; // to set the default root folder for the dialog

            folderBrowserDialog1.SelectedPath = @"E:\cahe"; // to set the default selected path for the dialog

            folderBrowserDialog1.ShowNewFolderButton = false; // to allow the user to create new folder from the dialog  

            if ( folderBrowserDialog1.ShowDialog()==DialogResult.OK )
            {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
            else
            {
                this.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button1_Click(sender: sender, e: e);
        }
    }
}
