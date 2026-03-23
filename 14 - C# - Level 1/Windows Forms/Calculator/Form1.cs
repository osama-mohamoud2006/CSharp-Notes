using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

      

        private void Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
            ResultLabel.ForeColor = Color.Black;
        }

        private void DeepGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
            ResultLabel.ForeColor = Color.White;
        }

        private void Bisque_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
            ResultLabel.ForeColor = Color.Olive;

        }

        private void Black_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            ResultLabel.ForeColor = Color.White;
        }



    }
}
