using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        // Hard Coded Pass And Email For Testing only !!
        string Pass = "123456";
        string email = "123@test.com"; 

        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            dateTimePicker1.MaxDate = DateTime.Now; // to avoid user select future date
        }

        bool CheckPassAndEmail()
        {
            return (MaskPass.Text == Pass && tbEmail.Text == email); // return true
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var temp = sender as TextBox;
            if(String.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true; // to avoid user leave the control 
                errorProvider1.SetError(temp, "Empty Or Null Text Box!");
            }
            else
            {
                e.Cancel = false; // to avoid user leave the control 
                errorProvider1.SetError(temp, "");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var res = MessageBox.Show("Are You Sure You Want To Leave", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
            else // yes 
            {
                e.Cancel = false;
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(!MaskPass.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider1.SetError(MaskPass, "Fill The Password With 6 Chars");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(MaskPass, "");
            }
        }

        private void MaskPass_Validated(object sender, EventArgs e)
        {
            if (MaskPass.MaskCompleted && !String.IsNullOrEmpty(tbEmail.Text))
            {
                if (CheckPassAndEmail()) // if they are correct 
                {
                    tabControl1.TabPages[1].Enabled = true;
                    tabControl1.TabPages[2].Enabled = true;
                    MessageBox.Show("Login Success!");

                }
                else
                {
                    MessageBox.Show("Wrong Pass Or Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MaskPass_Validated(sender, e); // call this event as they behaves the same 
        }

        private void maskedTextBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if(!MaskedTbSalary.MaskCompleted)
            {
               e.Cancel = true;
                errorProvider1.SetError(MaskedTbSalary, "Fill The Password With 6 Chars");
            }
            else 
            {   
                e.Cancel = false;
                errorProvider1.SetError(MaskedTbSalary, "");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labAge.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
        }


        void AddNewPersonToList()
        {
            ListViewItem item = new ListViewItem(tbName.Text);

            item.SubItems.Add(labAge.Text);

            item.SubItems.Add(MaskedTbSalary.Text);

            listView1.Items.Add(item);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            textBox1_Validating(sender, e); // for validating 

        }
    }
}
