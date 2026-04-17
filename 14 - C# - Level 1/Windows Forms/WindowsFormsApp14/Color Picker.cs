using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class ImageOpacity : Form
    {
        public ImageOpacity()
        {
            InitializeComponent();
        }

  
        private Color SetCustomColor(int r1 , int r2 , int r3)
        {
            return Color.FromArgb(r1, r2, r3);
        }


   
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = SetCustomColor(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            label1.Text = trackBar1.Value.ToString() + "," + trackBar2.Value.ToString() + "," + trackBar3.Value.ToString();
        }
    }
}
