using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Properties;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fuiButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true; pictureBox1.Image = Resources.images;
        }

        private void fuiButton2_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Visible)
                pictureBox1.Visible = true;

            pictureBox1.Image = Resources.dc76d5830cf8a886ea6915226b5177c1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.dc76d5830cf8a886ea6915226b5177c1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\wwwhd\Downloads\imag4es.jpg");

        }

        private void fuiButton3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox1.Image = null;
        }

        private void fuiButton4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.Image = Clipboard.GetImage();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void fuiButton5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Title = "Select an image(external)";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox4.Image = Image.FromFile(ofd.FileName);

                }
            }

        }
    }
}
