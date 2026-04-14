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
   

        bool CanAdd()
        {
            return (String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbId.Text) ||
                String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPhone.Text)
                || (GetGender() == ' ')  || String.IsNullOrEmpty(tbDateOfBirth.Text) ) ? false : true;
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
            item.SubItems.Add(""); // age 
            item.SubItems.Add(tbId.Text);
            item.SubItems.Add(tbPhone.Text);
            item.SubItems.Add(GetGender().ToString());

            listView1.Items.Add(item);
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

            //MessageBox.Show(date.Length.ToString());

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
               // MessageBox.Show(tbDateOfBirth.Text.Length.ToString());
                lblAge.Text = GetAgeFromDateOfBirth(tbDateOfBirth.Text);
                
            }

        }




    }
}
