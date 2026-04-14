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
                String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPhone.Text)) ? false : true;
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


        private void WhatWasFilledInTb(RichTextBox tb)
        {
            switch (tb.Tag.ToString())
            {
                case "EnteredName":
                    lblPerson.Text = tb.Text;
                    break;
            }
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox tb = sender as RichTextBox;
            WhatWasFilledInTb(tb);
        }
    }
}
