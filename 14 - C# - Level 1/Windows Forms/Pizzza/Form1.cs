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
            AssignTagsValuesForRadioButtons(); // for assigning values for radio controls.tag
            AssignTagsValuesForCheckBoxes(); // for assigning values for check boxes  controls.tag

        }

        // to call it after updating price (on screen on the real time) 
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
        /// The Section Of grb1,2 for radio buttons (prices for now )
        /// </summary>
        
        // This Function Is Used To Assign Name,Price For Each Control Tag (radio buttons) 
        // it runs when form loads 
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


        // This Function Is Used To Assign Name,Price For Each Control Tag (check boxes )
        // it runs when form loads 
        private void AssignTagsValuesForCheckBoxes()
        {
            // Rectangle 2D array 3*2
            string[,] NameOfEachRB = 
             {
                {"Extra Cheese","Onion"}  // R1
               ,{"Mushrooms","Olives"}//R2
               ,{"Tomatoes","Green Peppers"}//R3
            }; 
            
           
            float[,] PricesForEachRB = 
                {
                  {2.70f,1.60f} ,//R1
                  {2.1f,1.4f}, //R2
                   {1.99f,1.40f }//R3
                  
                 };

            CheckBox[,] CB = 
             {
                { cbExtraCheese , cbOnion},
                {cbMushrooms,cbOlives },
                {cbTomatomes,cbGreenPeppers }
            }; 

        

            for(int i=0; i< NameOfEachRB.GetLength(0); i++)
            {
                for (int j = 0; j < NameOfEachRB.GetLength(1); j++)
                {
                    DataForEachTag.name = NameOfEachRB[i, j];
                    DataForEachTag.price = PricesForEachRB[i, j];
                    CB[i, j].Tag = DataForEachTag;
                }

            }

        }




        // For The First Group "Radio Button Of Select Size" /// --> don't touch it //////
        private RadioButton TheLastRbOfSize = null; // to store the last user choice of radio buttons(size)
        private void UpdatePriceForSizesRadioButtons(object sender, EventArgs e)
        {
            if (TheLastRbOfSize != null) // get rid of the last operation price user did 
            {
                stDataForEachTag DataForRB = (stDataForEachTag)TheLastRbOfSize.Tag;
                this._TotalPrice -= DataForRB.price;
              
            }

            RadioButton[] Group1OfSizes = { rbSmall, rbMeduim, rbLarge};

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


        // For The First Group "Radio Button Of Select Crust" /// --> don't touch it //////
        private RadioButton TheLastRbOfCurstType = null; // to store the last user choice of radio buttons(crust type)
        private void UpdatePriceForCurstTypeRadioButtons(object sender, EventArgs e)
        {
            if (TheLastRbOfCurstType != null) // get rid of the last operation price user did 
            {
                stDataForEachTag DataForRB = (stDataForEachTag)TheLastRbOfCurstType.Tag;
                this._TotalPrice -= DataForRB.price;

            }

            RadioButton[] Group2OfCurstTypes = { rbThin, rbThick };

            foreach (RadioButton RB2 in Group2OfCurstTypes)
            {
                if (RB2.Checked) // if one of radio buttons was checked,then add the price to total 
                {
                    stDataForEachTag DataForRB = (stDataForEachTag)RB2.Tag; // take each tag and cast to to stuct to get its price
                    this._TotalPrice += DataForRB.price;
                    TheLastRbOfCurstType = RB2; // stores the last operation  
                }
            }

            UpdatePriceLabel();
        }


        /// <summary>
        ///  Check Boxes Logic 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExtraCheese.CheckState == CheckState.Checked )
            {
                MessageBox.Show("Checked");
                this._TotalPrice += 11;
                UpdatePriceLabel();
            }
         

        }

        private void cb_Unchecked(object sender, EventArgs e)
        {
            if (cbExtraCheese.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("UNChecked");
                this._TotalPrice -= 11;
                UpdatePriceLabel();
            }
        }
    }
}
