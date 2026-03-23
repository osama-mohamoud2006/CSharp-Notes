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
        enum enRandomColors: byte
        {
            violet =1 , beige =2 , bisque =3 , brown =4 , blue =5 
        }



        public Form1()
        {
            InitializeComponent();
        }


        // Control : Button
        // Event 
        private void button2_Click(object sender, EventArgs e) // Event: when User click on the button the content of box1 will be assigned as a content of box2 
        {
         
            Box2.Text = Box1.Text; // copy the content of text box 1 to text box2 
            DisableButton.Enabled = true;
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
            DisableButton.BackColor = Color.Red;
            EnableBox.BackColor = Color.White;
            Box1.Enabled = false; // disable the text box 1
            EnableBox.Enabled = true; // enable the button if i pressed this DisableButton
            DisableButton.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            Box2.Text = Box1.Text;
            DisableButton.Enabled = true;
            MessageBox.Show("Event: The Action Is Mouse Entering The Button The Response Is Copying The Text");
        }

        private void EnableBox_Click(object sender, EventArgs e)
        {
            DisableButton.BackColor = Color.White;
            EnableBox.BackColor = Color.Red; 
            Box1.Enabled = true; // enable the text box 1 again 
            DisableButton.Enabled = true;
            EnableBox.Enabled = false; 
        }

        private void HideTextBoxOne_Click(object sender, EventArgs e)
        {
            this.Text = "Disabled All";
            Box1.Visible = false;
            DisableButton.Enabled = false;
            EnableBox.Enabled = false;
            button2.Visible = false;
            DisableButton.Visible = false;
            button1.Visible = false;
            EnableBox.Visible = false;
            Box2.Visible = false;
            EnableAll.Visible = true;

            HideTextBoxOne.Enabled = false;
            HideTextBoxOne.Visible = false;
            BoxOneToBRed.Visible = false;
            TextBoxOneBWhite.Visible = false;
            RandomColorOfForm.Visible = false;
            ChangeTitle.Visible = false;

            MessageBox.Show("As You Disabled Main Text Box , So Every Thing Is Also Disabled");
            System.Media.SystemSounds.Beep.Play();
           
        }

        private void EnableAll_Click(object sender, EventArgs e)
        {
            this.Text = "Enabled All";
              Box1.Visible = true;
            DisableButton.Enabled = true;
            EnableBox.Enabled = true;
            button2.Visible = true;
            DisableButton.Visible = true;
            button1.Visible = true;
            EnableBox.Visible = true;
            Box2.Visible = true;

            HideTextBoxOne.Visible = true;
            HideTextBoxOne.Enabled = true; 
            EnableAll.Visible = false;
            BoxOneToBRed.Visible = true;
            TextBoxOneBWhite.Visible = true;
            RandomColorOfForm.Visible = true;
            ChangeTitle.Visible = true; 

            MessageBox.Show("As You Enabled Main Text Box , So Every Thing Is Also Enabled");
        
            System.Media.SystemSounds.Beep.Play();
          

        }

        private void BoxOneToBRed_Click(object sender, EventArgs e)
        {
            Box1.BackColor = Color.Red;
            
        }

       

        private void TextBoxOneBWhite_Click_1(object sender, EventArgs e)
        {
            Box1.BackColor = Color.White;
        }


        private byte GetRandomNumber()
        {
            Random Rnd = new Random();
           return (byte)Rnd.Next(1,6);
        }

        private void ChangeFormBackgroundColorRandomly(enRandomColors selectedColor, out string ColorName)
        {
           
            ColorName = "white";
            switch (selectedColor)
            {
                case enRandomColors.violet:
                    this.BackColor = Color.Violet;
                    ColorName = enRandomColors.violet.ToString();
                    break;

                case enRandomColors.brown:
                    this.BackColor = Color.Brown;
                    ColorName = enRandomColors.brown.ToString();
                    break;

                case enRandomColors.blue:
                    this.BackColor = Color.Blue;
                    ColorName = enRandomColors.blue.ToString();
                    break;

                case enRandomColors.bisque:
                    this.BackColor = Color.Bisque;
                    ColorName = enRandomColors.bisque.ToString();
                    break;

                case enRandomColors.beige:
                    this.BackColor = Color.Beige;
                    ColorName = enRandomColors.beige.ToString();
                    break;

            }
        }

        private void ChangeColorRandomly_Click(object sender, EventArgs e)
        {
            string ColorName; 
            ChangeFormBackgroundColorRandomly(selectedColor:(enRandomColors)GetRandomNumber(), ColorName: out ColorName);
            RandomColorOfForm.ForeColor = Color.Green; 
            MessageBox.Show($"The Form Background Color Has Changed To {ColorName}");
            System.Media.SystemSounds.Beep.Play();
        }

        private void ChangeTitle_Click(object sender, EventArgs e)
        {
           this.Text =  Box1.Text;
            MessageBox.Show("The Title Of Form Has Changed!");
        }
    }
}
