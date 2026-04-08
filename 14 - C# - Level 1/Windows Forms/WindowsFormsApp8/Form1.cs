using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = false; 
        }


        void ChangeLinkLabel(string item)
        {
            switch(item.ToLower())
            {
                case "github":
                    linkLabel1.Text = "GitHub";
                    linkLabel1.ForeColor = Color.WhiteSmoke;
                    break;

                case "instagram":
                    linkLabel1.Text = "Instagram";
                    linkLabel1.ForeColor = Color.LightPink;
                    break;

                case "email":
                    linkLabel1.Text = "Email";
                    linkLabel1.ForeColor = Color.LightYellow;
                    break;

            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox item = (ComboBox)sender;
            ChangeLinkLabel(item.ToString()); // change the link text
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cat;
        }

      

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gojo_satoru;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}
