using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Properties;

namespace WindowsFormsApp5
{
    public partial class FrmExercise : Form
    {
        public FrmExercise()
        {
            InitializeComponent();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            picTheViewer.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\picGril.jpg");
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {

            picTheViewer.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\38459.jpg");

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            picTheViewer.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\6d4099be-dc52-43a4-82ef-6e4bb36e436d.jpg");
        }

        private void rbBooks_CheckedChanged(object sender, EventArgs e)
        {
            picTheViewer.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\PicBooks .jpg");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            picTheViewer.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\closeup-shot-beautiful-ginger-domestic-kitten-sitting-white-surface.jpg");
        }
    }
}
