using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactored_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private float CalcPriceOfSize()
        {
            if (rbSmall.Checked) // return true if it checked
                return Convert.ToSingle(rbSmall.Tag);

            if(rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
           
            if(rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);

            return 0;
        }

        private float CalcPriceOfCurstType()
        {
            if (rbThinCrust.Checked)
                return Convert.ToString(rbThinCrust.Tag);

            if(rbThinCrust.Checked)
                return Convert.ToString(rbThinCrust.Tag);
            return 0; 
        }
        
        private float CalcPriceOfToppings() // in check box you can check more than one check box 
        {
            float total = 0;

            if (chkExtraChees.Checked)
                total += Convert.ToSingle(chkExtraChees.Tag);

            if(chkGreenPeppers.Checked)
                total += Convert.ToSingle(chkGreenPeppers.Tag);

            if(chkMushrooms.Checked)
                total += Convert.ToSingle(chkMushrooms.Tag);

            if(chkOlives.Checked)
                total += Convert.ToSingle(chkOlives.Tag);

        }

        private float GetTotalPrice() // take the price of each group then get the total of them 
        {
            return CalcPriceOfSize()+ CalcPriceOfCurstType();
        }


        private void UpdatePrice()
        {
            lblTotalPrice.Text = "$"+GetTotalPrice().ToString();
        }

        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void DisableGroups()
        {
            gbCrustType.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
        }

        private void SetAllControlsToDefaultValues()
        {
            rbEatIn.Checked = true;
           
            rbSmall.Checked = true;    
            rbThinCrust.Checked = true;

            // toppings
            chkExtraChees.Checked= false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatos.Checked = false;


        }
        private void EnableGroups()
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            var Res = MessageBox.Show("Are you sure you want to order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                DisableGroups();
                btnOrderPizza.Enabled = false;
                MessageBox.Show("Your Order Has Been Confrimed","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
               
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            EnableGroups();
            SetAllControlsToDefaultValues();
            btnOrderPizza.Enabled = true;
        }

      
    }

}
