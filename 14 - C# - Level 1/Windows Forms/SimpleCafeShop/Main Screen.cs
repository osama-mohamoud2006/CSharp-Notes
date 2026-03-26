using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private bool ShowOrderConfirmationMessageBox(string text = "Are You Sure?" , string title = "Confirmation")
        {
            var Res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (Res == DialogResult.OK)
                return true;
            else return false; 

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


        enum enOrders: byte { Coffee=1,Espresso=2,Matcha=3}

        private List<string> Lis = new List<string>();

        private void AppendToSummary(enOrders OrderName, string Price)
        {
            
            switch (OrderName)
            {
                case enOrders.Coffee:
                    txtboxSummary.Text += "\n"+enOrders.Coffee.ToString()+":"+Price;
                    Lis.Add(enOrders.Coffee.ToString() + ":" + Price);
                    break;

                case enOrders.Espresso:
                    txtboxSummary.Text += "\n"+enOrders.Espresso.ToString() + ":" + Price;
                    Lis.Add( enOrders.Espresso.ToString() + ":" + Price);
                    break;

                case enOrders.Matcha:
                    txtboxSummary.Text+=( "\n"+enOrders.Matcha.ToString() + ":" + Price);
                    Lis.Add( enOrders.Matcha.ToString() + ":" + Price);
                    break;
            }
        }


        // Order Now Button Click 

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 30;

                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                AppendToSummary(enOrders.Coffee,"30$");

                btnCoffeeUndo.Enabled = true;
            }
        }

        private void btnEsp_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 60;
                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                AppendToSummary(enOrders.Espresso, "60$");

                btnEspUndo.Enabled = true;
            }
        }

        private void btnMatcha_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                this.SumOfPrices += 70;
                labPrice.Text = Convert.ToString(SumOfPrices + "$");

                AppendToSummary(enOrders.Matcha, "70$");

                btnMatchaUndo.Enabled = true;
            }
        }



        ///  Undo The Order

        private void UndoFromSummary(enOrders WhatToUndo,string Price)
        {


            // "\n"+enOrders.Coffee.ToString()+":"+Price; --> the text to remove is be like

            switch (WhatToUndo)
            {
                case enOrders.Coffee:
                    Lis.Remove(enOrders.Coffee.ToString()+ ":" + Price);
                    break;

                case enOrders.Espresso:
                    Lis.Remove( enOrders.Espresso.ToString() + ":" + Price);
                    break;


                case enOrders.Matcha:
                    Lis.Remove( enOrders.Matcha.ToString() + ":" + Price);
                    break;

            }

            txtboxSummary.Text = ""; 

            if (Lis.Count == 0) return; // all orders were deleted , so delete the summary also 
            else
            {

                foreach (var items in Lis) // write new list to the screen 
                {
                    txtboxSummary.Text +=  items+ "\n";
                }


            }
        }

        private short[] prices = { 30, 60, 70 };

        private void UndoOrder(byte OrderNum)
        {
            if (OrderNum - 1 == -1 || OrderNum - 1 > prices.Length) return;  // to avoid out of range index 

            this.SumOfPrices -= prices[OrderNum-1]; // take the price of money from array
            labPrice.Text = Convert.ToString(SumOfPrices);
        }

        

        private bool IsInSummary(enOrders OrderName,string Price) // return true if the order in summary 
        {
            //Lis.Add(enOrders.Coffee.ToString() + ":" + Price);
            return Lis.Contains(OrderName.ToString() + ":" + Price);
        }

        private void UndoCoffeeOrder_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                UndoFromSummary(enOrders.Coffee, "30$");

                UndoOrder(1);
                // if the order isn't in summary then disable undo button
                if (!IsInSummary(enOrders.Coffee, "30$")) btnCoffeeUndo.Enabled = false;
            }
        }

        private void EspUndoOrder_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                UndoFromSummary(enOrders.Espresso, "60$");
                UndoOrder(2);
                // if the order isn't in summary then disable undo button
                if (!IsInSummary(enOrders.Espresso, "60$")) btnEspUndo.Enabled = false;
            }
        }

        private void MatchUndoOrder_Click(object sender, EventArgs e)
        {
            if (ShowOrderConfirmationMessageBox())
            {
                UndoFromSummary(enOrders.Matcha, "70$");

                UndoOrder(3);
                // if the order isn't in summary then disable undo button
                if (!IsInSummary(enOrders.Matcha, "70$")) btnMatchaUndo.Enabled = false;
            }
        }

         

    }
}
