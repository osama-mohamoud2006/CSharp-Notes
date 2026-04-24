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
            openFileDialog1.Filter = "png(*.png)|.*png|jpg(.*jpg)|.*jpg";

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                OpenedBrowseFileDialog = true;
                timer1.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseForPhotos();
            this.btnBrowse.Enabled = false;
            btnRest.Enabled = true;
        }


        bool CheckFileExt(string FileName)
        {
            string[] AllowedExt = { "jpg", "png" };
            return AllowedExt.Contains(Path.GetExtension(FileName.ToLower()));
        }

        int Index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(OpenedBrowseFileDialog && Index<openFileDialog1.FileNames.Length)
            {

            }
        }
    }
}
