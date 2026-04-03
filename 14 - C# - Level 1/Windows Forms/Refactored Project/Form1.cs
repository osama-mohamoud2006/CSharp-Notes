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


        void DisableGroups()
        {
            gbCrustType.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
        }

        void EnableGroups()
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            var Res = MessageBox.Show("Are you sure you want to order?", "Confirm Order", MessageBoxButtons.YesNo);

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
            btnOrderPizza.Enabled = true;
        }


    }





}
