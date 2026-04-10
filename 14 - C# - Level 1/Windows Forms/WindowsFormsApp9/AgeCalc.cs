using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class AgeCalc : Form
    {
        public AgeCalc()
        {
            InitializeComponent();
        }

        private void AgeCalc_Load(object sender, EventArgs e)
        {

        }

        DateTime SelectedPicker;
        ComboBox CurrentOption=null;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            SelectedPicker = dateTimePicker1.Value;
           if(null!=CurrentOption) UpdateLabel(Sitem: CurrentOption.SelectedItem.ToString()); // to update after changing
         
        }


        void UpdateLabel(string Sitem)
        {

            if (String.IsNullOrEmpty(Sitem)) return;
            DateTime dt = DateTime.Now;
            TimeSpan sp = dt - (SelectedPicker); // the diff between now and per date 

          
            switch (Sitem)
            {
                case "Get Your Age in Days":
                    labRes.Text = "Your Age In Days: " + sp.Days;

                    break;

                case "Get Your Age in Hours":
                    labRes.Text = "Your Age In Hours: " + sp.TotalHours;

                    break;

                case "Get Your Age in Months":
                    labRes.Text = "Your Age In Months: " + (sp.Days / 30);

                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ComboBox Sitem = sender as ComboBox;
            CurrentOption = Sitem;
            UpdateLabel(Sitem:Sitem.SelectedItem.ToString());


        }

    }
}
