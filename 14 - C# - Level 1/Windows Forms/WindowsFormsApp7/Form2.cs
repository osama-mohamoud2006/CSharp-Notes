using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void ChangePhoto(int index)
        {
            switch (index)
            {
                case 0:
                   
                  pictureBox1.Image = Resources.PicBooks_;
                    break;

                case 1:
                    pictureBox1.Image = Resources._38459;
                    break;

                case 2:
                    pictureBox1.Image = Resources.picGril;
                    break;

                case 3:
                    pictureBox1.Image = Resources.X;
                    break;

            }

        }
        //*
        //
        //book
//        boy
//        girl
//لابوبو       

        //*/
        void ChangePhoto(string item)
        {
            switch (item.ToLower())
            {
                case "book":

                    pictureBox1.Image = Resources.PicBooks_;
                    break;

                case "boy":
                    pictureBox1.Image = Resources._38459;
                    break;

                case "girl":
                    pictureBox1.Image = Resources.picGril;
                    break;

                case "لابوبو":
                    pictureBox1.Image = Resources.X;
                    break;

            }

        }

        void ChangeLabel(int index )
        {
            switch (index)
            {
                case 0:
                    label1.Text = "books";
                    label1.ForeColor = Color.PowderBlue;
                    break;
                   

                case 1:
                    label1.Text = "Boy";
                    label1.ForeColor = Color.GreenYellow;
                    break;

                case 2:
                    label1.Text = "girl";
                    label1.ForeColor = Color.HotPink;
                    break;

                case 3:
                    label1.Text = "لا بوبو عمك";
                    label1.ForeColor = Color.Goldenrod;
                    break;

            }
        }


        void ChangeLabel(string  item)
        {
            switch (item.ToLower())
            {
                case "book":
                    label1.Text = "books";
                    label1.ForeColor = Color.PowderBlue;
                    break;


                case "boy":
                    label1.Text = "boy";
                    label1.ForeColor = Color.GreenYellow;
                    break;

                case "girl":
                    label1.Text = "girl";
                    label1.ForeColor = Color.HotPink;
                    break;

                case "لابوبو":
                    label1.Text = "لا بوبو عمك";
                    label1.ForeColor = Color.Goldenrod;
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ChangePhoto(comboBox.SelectedItem.ToString()); // the current selected item of combo box
            ChangeLabel(comboBox.SelectedItem.ToString());

            
            foreach (var item in comboBox.Items) // all items of combo box 
            {
                
            }
        }
    }
}
