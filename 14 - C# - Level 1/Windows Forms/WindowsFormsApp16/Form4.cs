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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

   

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var item = sender as ToolStripMenuItem; // color , font 

            //if (item != null)
            //{

            //    if (item.Text == "Change Color")
            //    {
            //        if (colorDialog1.ShowDialog() == DialogResult.OK)
            //        { 
            //            if(control==textBox1) label1.ForeColor = colorDialog1.Color;
            //          else if (control == button1) button1.ForeColor = colorDialog1.Color;
            //        }
            //    }

            //    else if(item.Text =="Change Font")
            //    {
            //        if (fontDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            if (control == textBox1) label1.Font =fontDialog1.Font;
            //            else if (control == button1) button1.Font = fontDialog1.Font;
            //        }
            //    }

            //}



        }

        Control control;
        private void Control_MouseHover(object sender, EventArgs e)
        {
            control = sender as Control;

      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = contextMenuStrip1.Items[1] as ToolStripMenuItem;
            item.Enabled = false; 


        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //if( e.ClickedItem.Text == "Change Color")
            //{
            //    MessageBox.Show("Change Color Clicked");
            //}
            //else if(e.ClickedItem.Text == "Change Font")
            //{
            //    MessageBox.Show("Change Font Clicked");
            //}

            contextMenuStrip1.Visible = true;

            var item = e.ClickedItem; // color , font 
            contextMenuStrip1.Visible = false;

            if (item != null)
            {

                if (item.Text == "Change Color")
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (control == textBox1) label1.ForeColor = colorDialog1.Color;
                        else if (control == button1) button1.ForeColor = colorDialog1.Color;
                    }
                }

                else if (item.Text == "Change Font")
                {
                    if (fontDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (control == textBox1) label1.Font = fontDialog1.Font;
                        else if (control == button1) button1.Font = fontDialog1.Font;
                    }
                }

            }

        }
    }
}

