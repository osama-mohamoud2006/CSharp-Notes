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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected item");
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                checkedListBox1.Items.Add(textBox1.Text);

                textBox1.Visible = false;
                textBox1.Text = null;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(0); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((checkedListBox1.Items.Count - checkedListBox1.CheckedItems.Count).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //foreach (var item in checkedListBox1.Items) // get the checked items 
            //{
            //    if(checkedListBox1.CheckedItems.Contains(item)) MessageBox.Show(item.ToString() + " Has checked");
            //}
            if (checkedListBox1.CheckedItems.Count == 0) return;

            for (var i = 1; i <= checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i - 1].ToString());
            }
            MessageBox.Show(checkedListBox1.Items[0].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return; // no thing to be unchecked

            for (var i = 1; i <= checkedListBox1.Items.Count; i++) // the all  items 
            {
                checkedListBox1.SetItemChecked(i-1, false); // false means uncheck it 
            }

        }
    }
}
