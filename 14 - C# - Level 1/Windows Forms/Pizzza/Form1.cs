using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzza
{
    public partial class frmMain : Form
    {
        private float _TotalPrice=0; 

        public frmMain()
        {
            InitializeComponent();
        }


        private struct stDataForEachTag
        {
            public string name ;
            public float price;
        }

        stDataForEachTag DataForEachTag;
        private void AssignTagsValues()
        {
            // Group 1
            DataForEachTag.name = "";
            DataForEachTag.price = 0.50f; 
            rbSmall.Tag = DataForEachTag;
            

        }


        // To Disable All Controls 
        private void DisableAllControls()
        {
            grbSummary.BackColor = Color.Transparent;
            grbSummary.Enabled = false;

            grbCrustTypes.BackColor = Color.Transparent;
            grbCrustTypes.Enabled = false;

            grbOfSizes.BackColor = Color.Transparent;
            grbOfSizes.Enabled = false;

            grbTopping.BackColor = Color.Transparent;
            grbTopping.Enabled = false;

            grbWhereToEat.BackColor = Color.Transparent;
            grbWhereToEat.Enabled = false; 
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddToTotalPriceForGrp1()
        {
            RadioButton[] Group1OfSizes = {rbSmall , rbMeduim , rbLarge}; 
            foreach (RadioButton RadioButton in Group1OfSizes)
            {
                if(RadioButton.Checked) // if one of radio buttons was checked 
                {

                }
            }
        }
    }
}
