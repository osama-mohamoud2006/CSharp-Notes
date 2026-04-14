using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView1.Items.Add("item 1");
           
            listView1.Items.Add("item 2");
                listView1.Items.Add("item 3");

           




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show($"You Have Selected {listView1.SelectedItems} ");
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var temp = listView1.Items[0];

            foreach (var item in listView1.Items)
            {
                e.Item.Checked = true; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            listView1.Items.RemoveAt(listView1.Items.Count-1); // remove by index 
           // listView1.Items.Remove(listView1.Items["item 1"]); // remove by value
        }

        private void button2_Click(object sender, EventArgs e) //add 
        {
            ListViewItem item = new ListViewItem(richTextBox1.Text.Trim()); // to create item with subitems

            item.ImageIndex = 0; // to add image to the item
            item.SubItems.Add(DateTime.Now.Date.ToString("d")); // to make sub items for the item

            listView1.Items.Add(item); // to add an item to listview

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;    
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MessageBox.Show("Column " + e.Column.ToString());
            e.Column.ToString();
           
        }

        private void Clicked(object sender, EventArgs e)
        {

            MessageBox.Show("clicked on item "+listView1.SelectedIndices);
        }
    }
}
