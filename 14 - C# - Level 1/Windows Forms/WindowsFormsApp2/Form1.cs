using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Control : Button
        // Event 
        private void button2_Click(object sender, EventArgs e) // Event: when User click on the button the content of box1 will be assigned as a content of box2 
        {
            Box2.Text = Box1.Text; // copy the content of text box 1 to text box2 
            MessageBox.Show("You Have Clicked On The Button(action),So The Response Is Copying The Content Of Text Box1 To Text Box 2");
        }

       
        private void Box1_TextChanged(object sender, EventArgs e) // Event : when the text is changing on the text box 
        {
            System.Media.SystemSounds.Beep.Play();
            Box2.Text = Box1.Text;
            DisableButton.Enabled = true; // enable this button again 
            EnableBox.Enabled = false; 
        }

        // Event : when you press the disable button , it disables the text box 1 
        private void DisableButton_Click(object sender, EventArgs e)
        {
            Box1.Enabled = false; // disable the text box 1
            EnableBox.Enabled = true; // enable the button if i pressed this DisableButton
            DisableButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            Box2.Text = Box1.Text;
            MessageBox.Show("Event: The Action Is Mouse Entering The Button The Response Is Copying The Text");
        }

        private void EnableBox_Click(object sender, EventArgs e)
        {
            Box1.Enabled = true; // enable the text box 1 again 
            DisableButton.Enabled = true;
            EnableBox.Enabled = false; 
        }

        private void HideTextBoxOne_Click(object sender, EventArgs e)
        {
            Box1.Visible = false;
            DisableButton.Enabled = false;
            EnableBox.Enabled = false;
            button2.Visible = false;
            DisableButton.Visible = false;
            button1.Visible = false;
            EnableBox.Visible = false;
            Box2.Visible = false;
            MessageBox.Show("As You Disabled Main Text Box , So Every Thing Is Also Disable");
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
