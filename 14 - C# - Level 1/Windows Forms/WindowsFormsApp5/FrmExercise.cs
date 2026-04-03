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

        void UpdateLabel(object sender)
        {
            RadioButton Rb = (RadioButton)sender;
            labIndicator.Text = Rb.Text; 
        }

        private void UpdatePictureBox(object sender, EventArgs e)
        {
            RadioButton Rb = (RadioButton)sender;
            string Path = Convert.ToString(Rb.Tag);
            picTheViewer.Image = Image.FromFile(@Path);


            UpdateLabel(sender);
        }
    }
}
