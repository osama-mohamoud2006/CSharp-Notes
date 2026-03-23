using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Encryption
{
    public partial class Form1 : Form
    {
        private string res;
        private char letter; 
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptTextAl1(char letter,string EnteredText , out string Res )
        {
            Res = "";
            for(byte i =0; i< EnteredText.Length; i++)
            {
                Res += (char)(EnteredText[i] + letter); 
            }
        }

           private void UnEncryptTextAl1(char letter,string EnteredText , out string Res )
        {
            Res = "";
            for(byte i =0; i< EnteredText.Length; i++)
            {
                Res += (char)(EnteredText[i] - letter); 
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Undo.Visible = true;
            Undo.Enabled = true; // turn on the undo again after encrypt the text 

            string TextToEncrypt = EnteredByUser.Text;

            this.letter = 'z';
            EncryptTextAl1(letter: this.letter, TextToEncrypt,out  res);

            Result.Text = res;

         

        }

    

        private void EnteredByUser_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true; 
            button1.Enabled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Undo.Enabled = false; // turn off the button after undoing once 
            string REnteredText = res;


            UnEncryptTextAl1(letter: this.letter, EnteredText: REnteredText, out this.res);


            Result.Text = res; // undo --> results in text box

        }
    }
}
