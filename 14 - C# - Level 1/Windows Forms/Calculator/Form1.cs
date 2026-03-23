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

        private List<string> TheEqList;
        string EqToPush=""; // every num is concated with string after pressing op it push it to list

        decimal Result=0m; 

        public Calculator()
        {
            InitializeComponent();
            Obj = new Core();
            TheEqList = new List<string>();
            Equal.Enabled = false;
        }

      
        private void AppendToScreen(string text)
        {
            Screen.Text += text ;
            AC.Enabled = true;
            DeleteLast.Enabled = true;
            Equal.Enabled = true;
        }
        private void PopTheScreen()
        {
          
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1); // remove the last num 

        }

        private void RestEq()
        {
            EqToPush= "";
            TheEqList.Clear();
            EnableAllOperations();
            Equal.Enabled = false;
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


        // buttons of nums //

        private void One_Click(object sender, EventArgs e)
        {
            EqToPush += "1";
            AppendToScreen("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            EqToPush += "2";
            AppendToScreen("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            EqToPush+="3";
            AppendToScreen("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            EqToPush += "4"; ;
            AppendToScreen("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            EqToPush += "5" ;
            AppendToScreen("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            EqToPush += "6";
            AppendToScreen("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            EqToPush += "7";
            AppendToScreen("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            EqToPush += "8";
            AppendToScreen("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            EqToPush += "9";
            AppendToScreen("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            EqToPush += "0";
            AppendToScreen("0");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            EqToPush += ".";
            AppendToScreen(".");
        }

        string PopArrString(string str)
        {
            string res = "";
            for(byte i =0; i<str.Length-1;i++)
            {
                res += str[i];
            }
            return res; 
        }

        private void DeleteLast_Click(object sender, EventArgs e)
        {
           if(!String.IsNullOrEmpty(Screen.Text)) // return true if it is null or empty 
            {
                PopTheScreen();
                Equal.Enabled = false;

                Result = 0;


                if (!String.IsNullOrEmpty(EqToPush) )
                {
                    EqToPush  = EqToPush.Remove(EqToPush.Length - 1); // remove the last element (pop) 
                }

                else if (TheEqList.Count >0)
                {
                    string Last = TheEqList[TheEqList.Count - 1];

                    if (!String.IsNullOrEmpty(Last)) TheEqList[TheEqList.Count - 1] = Last.Remove(Last.Length - 1);
                    
                    if(String.IsNullOrEmpty(Last))
                    {
                        TheEqList.RemoveAt(TheEqList.Count - 1);
                    }


                 }
             

                bool IsDigitsOnly = Decimal.TryParse(Screen.Text, out _); // _ discard  --> returns true if the string have nums only
                if (IsDigitsOnly)
                {
                    this.EnableAllOperations();
                }

            }
            else
            {
                Result = 0;
                AC.Enabled = false;
                DeleteLast.Enabled = false; // disable del button 
                Equal.Enabled = false;
                MessageBox.Show("You Cannot Delete More Than This!");
                System.Media.SystemSounds.Beep.Play();
            }
           
        }

        private void AC_Click(object sender, EventArgs e)
        {
            DeleteLast.Enabled = true; // enable delete button again 
            RestEq(); // rest the equation list 
            Screen.Text = "";
            AC.Enabled = false;
            EnableAllOperations();
            Equal.Enabled = true; 
        }


        // The Start Of Calc ///


        private void ImplementTheCalc()
        {
            decimal Num = 0m;
            if (TheEqList.Count==1)
            {
                Result = Convert.ToDecimal(TheEqList[0]);

            }

            for (int i=1; i<TheEqList.Count; i++)
            {
                if (TheEqList[i] == "") continue; 
                else Obj.SimpleCalc(N1: Convert.ToDecimal(TheEqList[i-1]), N2:Convert.ToDecimal( TheEqList[i]), enCurrentOperation, out Num);
               
                Result += Num;
                Num = 0; 
            }
            TheEqList.Clear();
            
        }

    
        void DisableAllOperations()
        {
            Multi.Enabled = false;
            Div.Enabled = false;
            Add.Enabled = false;
            Sub.Enabled = false;

        }

        void EnableAllOperations()
        {
            Multi.Enabled = true;
            Div.Enabled =true;
            Add.Enabled =true;
            Sub.Enabled =true;

        }


        private void Multi_Click(object sender, EventArgs e)
        {
            enCurrentOperation = Core.enOperation.Multi; 
            Screen.Text += "*";

            
            TheEqList.Add(EqToPush); // add the string number
          
           
            this.EqToPush = ""; //rest the string for new nums 

            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Div_Click(object sender, EventArgs e)
        {
            enCurrentOperation = Core.enOperation.Div;
            Screen.Text += "/";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Add_Click(object sender, EventArgs e)
        {
            enCurrentOperation = Core.enOperation.Add;
            Screen.Text += "+";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 

        }


        private void Sub_Click(object sender, EventArgs e)
        {
            enCurrentOperation = Core.enOperation.Add;
            Screen.Text += "-";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Equal.Enabled = true;
            DeleteLast.Enabled = false;
            TheEqList.Add(this.EqToPush);
            EqToPush = "";
           
           ImplementTheCalc();

            Screen.Text += "= " + this.Result;
            Result = 0;
            Equal.Enabled = false;
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            if (Screen.Text.Length ==0 ) Equal.Enabled = false; 

        }
    }
}
