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

namespace Pizzza
{
    public partial class frmMain : Form
    {
        private float _TotalPrice=0; 

        public frmMain()
        {
            InitializeComponent();
            AssignTagsValuesForRadioButtons(); // for assigning values for radio controls .tag
        }


        // to call it after updating price 
        private void UpdatePriceLabel()
        {
            labPrice.Text = Convert.ToString(_TotalPrice)+"$";
        }


        // To Disable All Controls (Later with after order)
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


        private struct stDataForEachTag
        {
            public string name ;
            public float price;
        }

       private stDataForEachTag DataForEachTag;

        /// <summary>
        /// The Section Of grb1,2 for radio buttons 
        /// </summary>
        
        // This Function Is Used To Assign Name,Price For Each Control Tag
        private void AssignTagsValuesForRadioButtons()
        {
            
            string[] NameOfEachRB = {"Small","Medium","Large","Thin","Thick"}; // name of each rb control 
            float[] PricesForEachRB= {10,20,30,2,5}; // price of each rb control 

            RadioButton[] Rb = { rbSmall ,rbMeduim ,rbLarge ,rbThin , rbThick}; // the radio buttons itself 

            int i = 0; // to access array 
            foreach (RadioButton item in Rb)
            {
                DataForEachTag.name = NameOfEachRB[i];
                DataForEachTag.price = PricesForEachRB[i];
                Rb[i].Tag = DataForEachTag; // assign the struct to each  rb tag 
                i += 1; // increment the index 
            }

        }

        private RadioButton TheLastRbOfSize = null; // to store the last user choice of radio buttons

        private void UpdatePriceForRadioButtons(object sender, EventArgs e)
        {
            if (TheLastRbOfSize != null) // get rid of the last operation price user did 
            {
                stDataForEachTag DataForRB = (stDataForEachTag)TheLastRbOfSize.Tag;
                this._TotalPrice -= DataForRB.price;
              
            }

            RadioButton[] Group1OfSizes = { rbSmall, rbMeduim, rbLarge,rbThin,rbThick };

            foreach (RadioButton RB in Group1OfSizes)
            {
                if (RB.Checked) // if one of radio buttons was checked,then add the price to total 
                {
                    stDataForEachTag DataForRB = (stDataForEachTag)RB.Tag; // take each tag and cast to to stuct to get its price
                    this._TotalPrice += DataForRB.price;
                    TheLastRbOfSize = RB; // stores the last operation  
                }
            }

            UpdatePriceLabel(); 
        }






    }
}
