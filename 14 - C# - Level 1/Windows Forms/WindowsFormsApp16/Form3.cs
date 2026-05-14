using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TestMenuStrip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Menu Clicked!");
        }


        void SwitchColor(string NameOfItem)
        {
            switch (NameOfItem.ToLower())
            {
                case "red":
                    this.BackColor = Color.Red;
                    break;

                case "blue":
                    this.BackColor = Color.Blue;
                    break;

                case "green":
                    this.BackColor= Color.Green;
                    break;

                case "purble":
                    this.BackColor=Color.Purple;
                    break;

                case "default":
                    this.BackColor = Color.White;
                    break;

            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                MessageBox.Show(item.Text);
                SwitchColor(item.Text);
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            SwitchColor(item.Text);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sub of item `1`"); 
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            label2.Text = item.Text; 
        }

        string Res;
        private void hiToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            Res += item.Text;
            label2.Text = Res;
        }
    }
}
