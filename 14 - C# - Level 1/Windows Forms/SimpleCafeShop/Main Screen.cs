using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCafeShop
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MouseEnteredCoffee(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Gold;
        }

        private void MouseLeftCoffee(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Transparent;
        }

        private void MouseEnteredEsp(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Gold;

        }

        private void EspLeft(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Transparent;
        }

        private void MatchaEnter(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Gold;
        }

    

        private void MatchLeft(object sender, EventArgs e)
        {
            labCoffe.ForeColor = Color.Transparent;

        }

      

       
    }
}
