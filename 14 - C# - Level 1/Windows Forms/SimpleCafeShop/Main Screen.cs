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
        private short SumOfPrices = 0;

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
            labCoffe.ForeColor = Color.Black;
        }

        private void MouseEnteredEsp(object sender, EventArgs e)
        {
            labEspresso.ForeColor = Color.Gold;

        }

        private void EspLeft(object sender, EventArgs e)
        {
            labEspresso.ForeColor = Color.Black;
        }

        private void MatchaEnter(object sender, EventArgs e)
        {
            labMatcha.ForeColor = Color.Gold;
        }


        private void MatchLeft(object sender, EventArgs e)
        {
            labMatcha.ForeColor = Color.Black;

        }

        private bool ShowOrderConfirmationMessageBox()
        {
            var Res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (Res == DialogResult.OK)
                return true;
            else return false; 

        }

        // Order Now Button Click 

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 30;

                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                btnUndo1.Enabled = true; 
            }
        }

        private void btnEsp_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 60;
                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                btnEspUndo.Enabled = true;
            }
        }

        private void btnMatcha_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 70;
                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                btnMatchaUndo.Enabled = true;
            }
        }


        // Mouse Entered-Left 
        private void MouseEnteredbtnCoffee(object sender, EventArgs e)
        {
            btnCoffee.Text = "Order Now";
        }

        private void MouseLeftbtnCoffee(object sender, EventArgs e)
        {
            btnCoffee.Text = "30$";
        }

        private void MouseEnterbtnEsp(object sender, EventArgs e)
        {
            btnEsp.Text = "Order Now";
        }

        private void MouseLeftEsp(object sender, EventArgs e)
        {
            btnEsp.Text = "60$";
        }

        private void MouseEnteredbtnMatcha(object sender, EventArgs e)
        {
            btnMatcha.Text = "Order Now";
        }

        private void MouseLeftbtnMatcha(object sender, EventArgs e)
        {

            btnMatcha.Text = "70$";
        }


       
        ///  Undo The Order
        

        private short[] prices = { 30, 60, 70 };

        private void UndoOrder(byte OrderNum)
        {
            if (OrderNum - 1 == -1 || OrderNum - 1 > prices.Length) return;  // to avoid out of range index 

            this.SumOfPrices -= prices[OrderNum-1]; // take the price of money from array
            labPrice.Text = Convert.ToString(SumOfPrices);
        }

     

        private void UndoCoffeeOrder_Click(object sender, EventArgs e)
        {
            UndoOrder(1);
            btnUndo1.Enabled = false; 
        }

        private void EspUndoOrder_Click(object sender, EventArgs e)
        {
            UndoOrder(2);
            btnEspUndo.Enabled = false;
        }

        private void MatchUndoOrder_Click(object sender, EventArgs e)
        {
            UndoOrder(3);
            btnMatchaUndo.Enabled = false; 
        }

         
        




        // Implement Message Box With Events

    }
}
