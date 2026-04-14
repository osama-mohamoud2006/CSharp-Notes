using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp13.Properties;

namespace WindowsFormsApp13
{
    public partial class Exercise_on_emp_management : Form
    {
        public Exercise_on_emp_management()
        {
            InitializeComponent();
            listView1.Items.Add("3mak");
        }

    
        char GetGender()
        {
            if(rbMale.Checked)
            {
                Avater.Image = Resources.boy;
                return 'M';
            }
            else if (rbFemale.Checked)
            {
                Avater.Image = Resources.girl;
                return 'F';
            }
            return ' ';
        }
   
        int IndexOfImageAccordingToUserChoice()
        {
            if (rbMale.Checked)
            {
                return 0;
            }
            else if (rbFemale.Checked)
            {
                Avater.Image = Resources.girl;
                return 1;
            }
            return 2;
        }
        

        void RestLabels()
        {
            lblPerson.Text = "person";
             lblEmail.Text = "     @     ";
            lblPhone.Text = "+204";
            lblId.Text = "23453";
            lblAge.Text = "0";
        }

        void RestUserInputs()
        {
            tbDateOfBirth.Clear();
            tbEmail.Clear();
            tbId.Clear();
            tbName.Clear();
            tbPhone.Clear();
            if (rbFemale.Checked) rbFemale.Checked = false;
            if (rbMale.Checked) rbMale.Checked = false;
            UpDownFrom.Value = 0;
            UpDownTo.Value = 0;

            Avater.Image = Resources.user;
            RestLabels();
        }

        bool CanAdd()
        {
            return (!tbEmail.MaskCompleted || !tbId.MaskCompleted ||
                String.IsNullOrEmpty(tbName.Text) || !tbPhone.MaskCompleted
                || (GetGender() == ' ')  || !tbDateOfBirth.MaskCompleted  ) ? false : true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CanAdd())
            {
                MessageBox.Show("You Can n't Add There Are Empty Fields! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            ListViewItem item = new ListViewItem(tbName.Text); // add name as the main item \


            item.SubItems.Add(tbEmail.Text) ;
            item.SubItems.Add(GetAgeFromDateOfBirth(tbDateOfBirth.Text)); // age 
            item.SubItems.Add(tbId.Text);
            item.SubItems.Add(tbPhone.Text);
            item.SubItems.Add(GetGender().ToString());
            item.ImageIndex= IndexOfImageAccordingToUserChoice();

            listView1.Items.Add(item);

            RestUserInputs();
        }


        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            lblPerson.Text = tbName.Text;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            GetGender();
        }

        // Text Changed Events For masking the entered data in the labels
   
        string GetAgeFromDateOfBirth(string text) //10
        {
            if(String.IsNullOrEmpty(text))
            {
                return "0";
            }
            string[] date = text.Split('/'); // 2006/8/1

      

            if (date.Length == 3)
            {
                if (!(String.IsNullOrEmpty(date[0]) || String.IsNullOrEmpty(date[1]) || String.IsNullOrEmpty(date[2])) )
                {

                    DateTime DateOfBirth = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])); // convert it to date

                    TimeSpan diff = DateTime.Now - DateOfBirth;

                    return Math.Floor(diff.TotalDays/365).ToString();
                }

                else return "0";
            }

             return "0";
        }


        private void MaskTb_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox tb = sender as MaskedTextBox;

            if (tbPhone == tb)
            {
                lblPhone.Text = tbPhone.Text;
            }

            else if (tbId == tb)
            {
                lblId.Text = tbId.Text;
            }
            else if(tbEmail == tb)
            {
                lblEmail.Text = tbEmail.Text;
            }
            else if (tbDateOfBirth == tb)
            {
               
                lblAge.Text = GetAgeFromDateOfBirth(tbDateOfBirth.Text);
                
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedItems != null && listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("There Are No Items To Remove Or You Didn't Select An Item ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedItem.ToString())
            {
                case "Details":
                    listView1.View = View.Details;
                    break;

                case "Large Icons":
                    listView1.View= View.LargeIcon;
                    break;

                   case "List":
                    listView1.View = View.List;
                    break;

                case "Small Icons":
                    listView1.View = View.SmallIcon;
                    break;

            }
        }


    }
}
