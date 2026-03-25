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
        private sbyte SumOfPrices = 0;

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

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            this.SumOfPrices += 30;
            labPrice.Text = Convert.ToString(SumOfPrices);
        }

        private void btnEsp_Click(object sender, EventArgs e)
        {
            this.SumOfPrices += 60;
            labPrice.Text = Convert.ToString(SumOfPrices);
        }

        private void btnMatcha_Click(object sender, EventArgs e)
        {
            this.SumOfPrices += 70;
            labPrice.Text = Convert.ToString(SumOfPrices);
        }

        private void MouseEnteredbtnCoffee(object sender, EventArgs e)
        {
            btnCoffee.Text = "Order Now";
        }
    }
}
