using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private Core Obj ;
        Core.enOperation enCurrentOperation;

        //private List<string> TheEq;
        string EqToPush=""; // every num is concated with string after pressing op it push it to list

        decimal Result; 

        public Calculator()
        {
            InitializeComponent();
            Obj = new Core();
            //TheEq = new List<string>(); 
        }

      
        private void AppendToScreen(string text)
        {
            Screen.Text += text ;
            AC.Enabled = true;
            DeleteLast.Enabled = true; 
        }
        private void PopTheScreen()
        {
          
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1); // remove the last num 

        }

        private void RestEq()
        {
            EqToPush= EqToPush.Remove(0);
        }


        //private void AddToEq(string num)
        //{
           
        //}
        //private void DeleteTheLastOfEq()
        //{
        //    this.TheEq.RemoveAt(TheEq.Count - 1);
        //}

        private void Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
            ResultLabel.ForeColor = Color.Black;
        }

        private void DeepGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
            ResultLabel.ForeColor = Color.White;
        }

        private void Bisque_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
            ResultLabel.ForeColor = Color.Olive;

        }

        private void Black_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            ResultLabel.ForeColor = Color.White;
        }

        private void One_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("1");
            AppendToScreen("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("2");
            AppendToScreen("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            EqToPush+="3";
            AppendToScreen("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("4");
            AppendToScreen("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("5");
            AppendToScreen("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("6");
            AppendToScreen("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("7");
            AppendToScreen("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("8");
            AppendToScreen("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("9");
            AppendToScreen("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            EqToPush.Concat("0");
            AppendToScreen("0");
        }

        private void DeleteLast_Click(object sender, EventArgs e)
        {
           if(!String.IsNullOrEmpty(Screen.Text)) // return true if it is null or empty 
            {
                PopTheScreen();
                EqToPush.Remove(EqToPush.Length - 1); // remove the last element (pop) 
            }
            else
            {
                MessageBox.Show("You Cannot Delete More Than This!");
                System.Media.SystemSounds.Beep.Play();
                AC.Enabled = false;
                DeleteLast.Enabled = false; // disable del button 
            }
           
        }

        private void AC_Click(object sender, EventArgs e)
        {
            DeleteLast.Enabled = true; // enable delete button again 
            RestEq(); // rest the equation list 
            Screen.Text = "";
            AC.Enabled = false; 
        }


        // The Start Of Calc ///

        private char ReturnCharAccordingToOpName() // take the current operation name and convert it to suitable operatore 
        {
            switch(enCurrentOperation)
            {
                case Core.enOperation.Add:
                    return '+';


                case Core.enOperation.Sub:
                    return '-';

                case Core.enOperation.Multi:
                    return '*';

                case Core.enOperation.Div:
                    return '/';

            }
            return '+';
        }

        void TheNumsOfEq(out string[] eqNums )// convert the string to 2 num between them operation 
        {
            eqNums = EqToPush.Split(ReturnCharAccordingToOpName());
        }

      
       private void ImplementTheCalc()
        {
            string[] eqNum; 
          
            TheNumsOfEq(out eqNum); // split the arr to nums 

            Obj.SimpleCalc(N1: Convert.ToDecimal(eqNum[0]), N2: Convert.ToDecimal(eqNum[2]), enCurrentOperation, out Result);

        }

        private void Multi_Click(object sender, EventArgs e)
        {
            enCurrentOperation = Core.enOperation.Multi; 
            Screen.Text += "*";
            EqToPush += "*";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            ImplementTheCalc();
            Screen.Text += "= " + this.Result; 
        }




    }
}
