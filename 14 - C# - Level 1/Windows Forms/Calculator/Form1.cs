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
        private string EqToPush =""; // every num is added to string after pressing op it push it to list

        private decimal Result =0m;

        private decimal AnsValue  ;

        public Calculator()
        {
            InitializeComponent();
            Obj = new Core();
            TheEqList = new List<string>();
            Equal.Enabled = false;
        }


        // Very Imp Operations /// 
        private void Screen_TextChanged(object sender, EventArgs e)
        {

            if (Screen.Text.Length == 0) Equal.Enabled = false;
           

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

        private void DisableAllNumsButtons()
        {
            Control[] Buttons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero };

            foreach (Control ctr in Buttons)
            {
                ctr.Enabled = false;
            }

        }

        private void EnableAllNumsButtons()
        {
            Control[] Buttons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero };

            foreach (Control ctr in Buttons)
            {
                ctr.Enabled = true;
            }

        }


        void DisableAllOperations()
        {
            Multi.Enabled = false;
            Div.Enabled = false;
            Add.Enabled = false;
            Sub.Enabled = false;
            Mod.Enabled = false;

        }

        void EnableAllOperations()
        {
            Multi.Enabled = true;
            DeleteLast.Visible = true;
            Div.Enabled = true;
            Add.Enabled = true;
            Sub.Enabled = true;
            Mod.Enabled = true;
           
        }


        // Themes ///

      private void Blue_Click(object sender, EventArgs e)
      {
         Color DarkBlue = Color.FromArgb(25, 77, 130);
         Color LightBlue = Color.FromArgb(220, 237, 247);
         Color MediumBlue = Color.FromArgb(100, 150, 200);

       this.BackColor = Color.LightSkyBlue;

    // Operators - Dark Blue
    Multi.BackColor = DarkBlue;
    Multi.ForeColor = Color.White;
    Div.BackColor = DarkBlue;
    Div.ForeColor = Color.White;
    Add.BackColor = DarkBlue;
    Add.ForeColor = Color.White;
    Sub.BackColor = DarkBlue;
    Sub.ForeColor = Color.White;
    Mod.BackColor = DarkBlue;
    Mod.ForeColor = Color.White;

    // Control buttons
    DeleteLast.BackColor = DarkBlue;
    DeleteLast.ForeColor = Color.White;
    AC.BackColor = DarkBlue;
    AC.ForeColor = Color.White;

    // Number buttons - Light Blue
    Button[] numberButtons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero, Dot };
    foreach (Button btn in numberButtons)
    {
        btn.BackColor = LightBlue;
        btn.ForeColor = Color.Black;
    }

    // Special buttons - Medium Blue
    Equal.BackColor = MediumBlue;
    Equal.ForeColor = Color.White;
    Ans.BackColor = MediumBlue;
    Ans.ForeColor = Color.White;

    // Text colors
    ResultLabel.ForeColor = Color.Black;
    Screen.ForeColor = Color.Black;
    Screen.BackColor = Color.White;
}

        private void Brown_Click(object sender, EventArgs e)
        {
        
            Color DarkBrown = Color.FromArgb(101, 67, 33);
            Color MediumBrown = Color.FromArgb(160, 120, 80);
            Color LightBrown = Color.FromArgb(210, 180, 150);
            Color CreamBackground = Color.FromArgb(245, 240, 230);

            this.BackColor = CreamBackground;

            // Operators - Dark Brown
            Multi.BackColor = DarkBrown;
            Multi.ForeColor = Color.White;
            Div.BackColor = DarkBrown;
            Div.ForeColor = Color.White;
            Add.BackColor = DarkBrown;
            Add.ForeColor = Color.White;
            Sub.BackColor = DarkBrown;
            Sub.ForeColor = Color.White;
            Mod.BackColor = DarkBrown;
            Mod.ForeColor = Color.White;

            // Control buttons
            DeleteLast.BackColor = DarkBrown;
            DeleteLast.ForeColor = Color.White;
            AC.BackColor = DarkBrown;
            AC.ForeColor = Color.White;

            // Number buttons - Light Brown
            Button[] numberButtons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero, Dot };
            foreach (Button btn in numberButtons)
            {
                btn.BackColor = LightBrown;
                btn.ForeColor = Color.Black;
            }

            // Special buttons - Medium Brown
            Equal.BackColor = MediumBrown;
            Equal.ForeColor = Color.White;
            Ans.BackColor = MediumBrown;
            Ans.ForeColor = Color.White;

            // Text colors
            ResultLabel.ForeColor = DarkBrown;
            Screen.ForeColor = DarkBrown;
            Screen.BackColor = Color.White;
        }

        private void Bisque_Click(object sender, EventArgs e)
        {
            Color DarkTerracotta = Color.FromArgb(153, 76, 0);
            Color MediumTerracotta = Color.FromArgb(204, 119, 34);
            Color LightPeach = Color.FromArgb(255, 228, 196);
            Color BisqueBackground = Color.FromArgb(255, 245, 238);

            this.BackColor = BisqueBackground;

            // Operators - Dark Terracotta
            Multi.BackColor = DarkTerracotta;
            Multi.ForeColor = Color.White;
            Div.BackColor = DarkTerracotta;
            Div.ForeColor = Color.White;
            Add.BackColor = DarkTerracotta;
            Add.ForeColor = Color.White;
            Sub.BackColor = DarkTerracotta;
            Sub.ForeColor = Color.White;
            Mod.BackColor = DarkTerracotta;
            Mod.ForeColor = Color.White;

            // Control buttons
            DeleteLast.BackColor = DarkTerracotta;
            DeleteLast.ForeColor = Color.White;
            AC.BackColor = DarkTerracotta;
            AC.ForeColor = Color.White;

            // Number buttons - Light Peach
            Button[] numberButtons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero, Dot };
            foreach (Button btn in numberButtons)
            {
                btn.BackColor = LightPeach;
                btn.ForeColor = Color.Black;
            }

            // Special buttons - Medium Terracotta
            Equal.BackColor = MediumTerracotta;
            Equal.ForeColor = Color.White;
            Ans.BackColor = MediumTerracotta;
            Ans.ForeColor = Color.White;

            // Text colors
            ResultLabel.ForeColor = DarkTerracotta;
            Screen.ForeColor = DarkTerracotta;
            Screen.BackColor = Color.White;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            Color NeonPurple = Color.FromArgb(138, 43, 226);
            Color DarkPurple = Color.FromArgb(75, 0, 130);
            Color LightGray = Color.FromArgb(220, 220, 220);

            this.BackColor = Color.Black;

            // Operators - Dark Purple
            Multi.BackColor = DarkPurple;
            Multi.ForeColor = Color.White;
            Div.BackColor = DarkPurple;
            Div.ForeColor = Color.White;
            Add.BackColor = DarkPurple;
            Add.ForeColor = Color.White;
            Sub.BackColor = DarkPurple;
            Sub.ForeColor = Color.White;
            Mod.BackColor = DarkPurple;
            Mod.ForeColor = Color.White;

            // Control buttons
            DeleteLast.BackColor = LightGray;
            DeleteLast.ForeColor = DarkPurple;
            AC.BackColor = LightGray;
            AC.ForeColor = DarkPurple;

            // Number buttons - Neon Purple
            Button[] numberButtons = { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Zero, Dot, Ans };
            foreach (Button btn in numberButtons)
            {
                btn.BackColor = NeonPurple;
                btn.ForeColor = Color.White;
            }

            // Special button
            Equal.BackColor = LightGray;
            Equal.ForeColor = DarkPurple;

            // Text colors
            ResultLabel.ForeColor = Color.White;
            Screen.ForeColor = Color.MediumVioletRed;
            Screen.BackColor = Color.Black;
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


        
        // Main Buttons // 
        private void DeleteLast_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Screen.Text)) // return true if it is null or empty 
            {
                PopTheScreen();
                Equal.Enabled = false;

                Result = 0;


                if (!String.IsNullOrEmpty(EqToPush))
                {
                    EqToPush = EqToPush.Remove(EqToPush.Length - 1); // remove the last element (pop) 
                }

                else if (TheEqList.Count > 0)
                {
                    string Last = TheEqList[TheEqList.Count - 1];

                    if (!String.IsNullOrEmpty(Last)) TheEqList[TheEqList.Count - 1] = Last.Remove(Last.Length - 1);

                    if (String.IsNullOrEmpty(Last))
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

        private void Equal_Click(object sender, EventArgs e)
        {
            DisableAllNumsButtons();
            DeleteLast.Visible = false;
            Equal.Enabled = true;
            DeleteLast.Enabled = false;
            TheEqList.Add(this.EqToPush);
            EqToPush = "";

            ImplementTheCalc();

            Screen.Text += "= " + this.Result;
            this.AnsValue = Result;
            Result = 0;
            Equal.Enabled = false;
            Ans.Visible = true;
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            DisableAllNumsButtons();
            DeleteLast.Visible = false; // enable delete button again 
            AC.Enabled = true;
            RestEq(); // rest the equation list 

            EnableAllOperations();
            
            Ans.Visible = false;

            Equal.Enabled = true;

            EqToPush = Convert.ToString(AnsValue);
            Screen.Text = "Ans";

           
        }

        private void AC_Click(object sender, EventArgs e)
        {
            DeleteLast.Enabled = true; // enable delete button again 
            RestEq(); // rest the equation list 
            Screen.Text = "";
            AC.Enabled = false;
            EnableAllOperations();
            Equal.Enabled = true;
            EnableAllNumsButtons(); 
        }


   // Main Logic Of Calc 
        private void ImplementTheCalc()
        {
            decimal Num = 0m;
            if (TheEqList.Count==1)
            {
                Result = Convert.ToDecimal(TheEqList[0]);
                return;

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

   // Operations Buttons . /

        private void EnableAllButtonsAfterAns() // enable all buttons again after ans 
        {
            if(One.Enabled == false) // checking one is enough 

                EnableAllNumsButtons();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            EnableAllButtonsAfterAns();
            enCurrentOperation = Core.enOperation.Multi; 
            Screen.Text += "*";

            
            TheEqList.Add(EqToPush); // add the string number
          
           
            this.EqToPush = ""; //rest the string for new nums 

            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Div_Click(object sender, EventArgs e)
        {
            EnableAllButtonsAfterAns();
            enCurrentOperation = Core.enOperation.Div;
            Screen.Text += "/";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Add_Click(object sender, EventArgs e)
        {
            EnableAllButtonsAfterAns();
            enCurrentOperation = Core.enOperation.Add;
            Screen.Text += "+";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 

        }

        private void Sub_Click(object sender, EventArgs e)
        {
            EnableAllButtonsAfterAns();
            enCurrentOperation = Core.enOperation.Sub;
            Screen.Text += "-";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            EnableAllButtonsAfterAns();
            enCurrentOperation = Core.enOperation.Mod;
            Screen.Text += "%";


            TheEqList.Add(EqToPush); // add the string number


            this.EqToPush = ""; //rest the string for new nums 
            DisableAllOperations(); // to avoid multi operations at the same time 
        }

       
    }
}
