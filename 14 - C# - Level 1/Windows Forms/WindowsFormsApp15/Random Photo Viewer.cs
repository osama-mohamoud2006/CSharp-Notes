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
    public partial class Random_Photo_Viewer : Form
    {
        public Random_Photo_Viewer()
        {
            InitializeComponent();
        }

        bool OpenedBrowseFileDialog = false; 

        void BrowseForPhotos()
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.FileName = "Photo.png";
            openFileDialog1.Title = "Select Photo(s)....."; 
            openFileDialog1.Filter = "Png(*.png)|*.png|Jpg(*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog()==DialogResult.OK) // if the selection was done 
            {
                OpenedBrowseFileDialog = true;
                timer1.Enabled = true;
            }
        }

        void UpdateNumOfPhotosLabel(int value)
        {
            labNumOfPhotos.Text = value.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseForPhotos();
            UpdateNumOfPhotosLabel(openFileDialog1.FileNames.Length);
            this.btnBrowse.Enabled = false;
            btnRest.Enabled = true;
            btnStop.Enabled = true; 
        }


        bool CheckFileExt(string FileName)
        {
            string[] AllowedExt = { ".jpg", ".png" };
            return AllowedExt.Contains(Path.GetExtension(FileName.ToLower())); // check if the path ext file contains the allowed ext by check if it is available in arr or not 
        }

        int Index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (openFileDialog1.FileNames.Length == 0) return;

            if(OpenedBrowseFileDialog && Index<openFileDialog1.FileNames.Length) // use index to get photos from arr of files
            {
                if (CheckFileExt(openFileDialog1.FileNames[Index])) // get the file name by index After Checking it is Valid File Or Not
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[Index]); // view the image 
                    Index++; // Move to the next file 
                }
            }
            else if(Index> openFileDialog1.FileNames.Length-1)
            {
                Index = 0; // rest the index 
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStop.Visible = false;
            btnContinue.Visible = true; // to enable the user to continue the show again 
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; //remove the current photo 
            btnRest.Enabled = false;
            btnBrowse.Enabled = true;
            btnStop.Enabled = false;
            UpdateNumOfPhotosLabel(0);
            numericUpDown1.Value = 100;
            timer1.Enabled = false;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           timer1.Interval= Convert.ToInt32(numericUpDown1.Value); // change the timer interval according to the num Up Down 
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnContinue.Visible = false;
            btnStop.Visible = true;
        }
    }
}
