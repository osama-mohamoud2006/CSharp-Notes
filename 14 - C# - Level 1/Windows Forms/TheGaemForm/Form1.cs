using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up the Paint event to draw the lines
            groupBox1.Paint += groupBox1_Paint;
        }



        // Add this method to handle drawing the Tic-Tac-Toe grid
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // Configure the pen (Color, Size)
            using (Pen pen = new Pen(Color.White, 5))
            {
                // Smooth the drawn lines
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dynamically calculate gaps between the picture boxes
                int vLine1X = pictureBox1.Right + (pictureBox2.Left - pictureBox1.Right) / 2;
                int vLine2X = pictureBox2.Right + (pictureBox3.Left - pictureBox2.Right) / 2;

                int hLine1Y = pictureBox1.Bottom + (pictureBox4.Top - pictureBox1.Bottom) / 2;
                int hLine2Y = pictureBox4.Bottom + (pictureBox7.Top - pictureBox4.Bottom) / 2;

                // Padding so the lines extend slightly past the picture boxes
                int margin = 10;
                int startX = pictureBox1.Left - margin;
                int endX = pictureBox3.Right + margin;
                int startY = pictureBox1.Top - margin;
                int endY = pictureBox7.Bottom + margin;

                // Draw Vertical Lines
                e.Graphics.DrawLine(pen, vLine1X, startY, vLine1X, endY);
                e.Graphics.DrawLine(pen, vLine2X, startY, vLine2X, endY);

                // Draw Horizontal Lines
                e.Graphics.DrawLine(pen, startX, hLine1Y, endX, hLine1Y);
                e.Graphics.DrawLine(pen, startX, hLine2Y, endX, hLine2Y);
            }
        }

    


        enum enCurrentPlayer : byte
        {
            none = 0,
            Player1 = 1,
            Player2 = 2
        }

        // player 1 --> O
        // player 2 --> X
        enCurrentPlayer currentPlayer = enCurrentPlayer.none;
        enCurrentPlayer prevPlayer = enCurrentPlayer.none;

        byte Totalcounter = 0; // counter to keep track of how many times player 2 (X) has played
      


        void ChangeCurrentPlayerLabelColor(enCurrentPlayer CurrentPlayer) // change the current player and update the label color accordingly
        {
            _ = CurrentPlayer == enCurrentPlayer.Player1 ? labCurrentPlayer.ForeColor = Color.Green : labCurrentPlayer.ForeColor = Color.Red; // change the label color based on the current player
        }

        void PictureBoxClick(enCurrentPlayer CurrentPlayer, PictureBox Currentpb)
        {
            Totalcounter++; // increment the counter each time a picture box is clicked (indicating a move has been made)
            switch (CurrentPlayer)
            {
                case enCurrentPlayer.Player1:
                    {//o

                        Currentpb.Image = Image.FromFile(@"E:\projects\C#\14 - C# - Level 1\Windows Forms\Tic-Tac-Toe2\Pics\oPixel.png");
                       
                        Currentpb.Enabled = false; // disable the picture box after it's clicked to prevent changing the image
                        Currentpb.Tag = CurrentPlayer.ToString(); // set the Tag property to identify which player made the move (useful for win/draw logic later)
                        break;
                    }

                case enCurrentPlayer.Player2:
                    { //x 
                        Currentpb.Image = Image.FromFile(@"E:\projects\C#\14 - C# - Level 1\Windows Forms\Tic-Tac-Toe2\Pics\xPixel.png");
                       
                        Currentpb.Enabled = false; // disable the picture box after it's clicked to prevent changing the image
                        Currentpb.Tag = CurrentPlayer.ToString(); // set the Tag property to identify which player made the move (useful for win/draw logic later)

                        break;
                    }

            }
        }

        void CurrentPlayerChange(object sender)
        {
            if (prevPlayer == enCurrentPlayer.Player2) // if the previous player was Player2, then it's Player1's turn
            {
                currentPlayer = enCurrentPlayer.Player1;
            }
            else if (prevPlayer == enCurrentPlayer.Player1)// if the previous player was Player1, then it's Player2's turn
            {
                currentPlayer = enCurrentPlayer.Player2;
            }
            else
            {
                currentPlayer = enCurrentPlayer.Player1;
            }

            ChangeCurrentPlayerLabelColor(currentPlayer);

            labCurrentPlayer.Text = currentPlayer.ToString(); // display current player in the label

            PictureBox pb = (PictureBox)sender;

            PictureBoxClick(currentPlayer, pb);
            prevPlayer = currentPlayer; // store the current player as previous player for the next turn

        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentPlayerChange(sender);

           // CalcTheProbOfWin(enCurrentPlayer.Player1); // check the probability of winning after each move to determine if the game has been won or is a draw
            //CalcTheProbOfWin(enCurrentPlayer.Player2);

            if (CalcTheProbOfWin(enCurrentPlayer.Player1) || CalcTheProbOfWin(enCurrentPlayer.Player2)) // if one of the players has won, or if it's a draw (which can be determined by checking if all picture boxes are filled without a winner), then end the game
            {
                EndGame(WhoWon); // if there's a winner or a draw, end the game
            }
            else if(Totalcounter== 9) // if all picture boxes are filled and there's no winner, it's a draw
            {
                MadeDraw();
            }


        }



        /// Track The Changes On Board To Check For Win Or Draw

   

        enCurrentPlayer WhoWon = enCurrentPlayer.none;

        bool CalcTheProbOfWin(enCurrentPlayer CurrentPlayer)
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

            // Check  (1,...,...)
            if (pictureBoxes[0].Tag.ToString() == CurrentPlayer.ToString())
            {
                if (pictureBoxes[3].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[6].Tag.ToString() == CurrentPlayer.ToString())
                {
                    WhoWon = CurrentPlayer;
                    return true;
                }
                else if (pictureBoxes[1].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[2].Tag.ToString() == CurrentPlayer.ToString())
                {
                    WhoWon = CurrentPlayer;
                    return true;
                }
                else if (pictureBoxes[4].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[8].Tag.ToString() == CurrentPlayer.ToString())
                {
                    WhoWon = CurrentPlayer;
                    return true;
                }

            }

            // Check (3,...,...)
            if (pictureBoxes[2].Tag.ToString() == CurrentPlayer.ToString())
            {
                if (pictureBoxes[5].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[8].Tag.ToString() == CurrentPlayer.ToString())
                {
                    WhoWon = CurrentPlayer;
                    return true;
                }

                else if (pictureBoxes[4].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[6].Tag.ToString() == CurrentPlayer.ToString())
                {
                    WhoWon = CurrentPlayer;
                    return true;
                }
            }


            if (pictureBoxes[1].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[4].Tag.ToString() == CurrentPlayer.ToString()
                && pictureBoxes[7].Tag.ToString() == CurrentPlayer.ToString())
            {

                WhoWon = CurrentPlayer;
                return true;
            }

            if (pictureBoxes[3].Tag.ToString() == CurrentPlayer.ToString() && (pictureBoxes[4].Tag.ToString() == CurrentPlayer.ToString()) && pictureBoxes[5].Tag.ToString() == CurrentPlayer.ToString())
            {

                WhoWon = CurrentPlayer;
                return true;
            }

            if (pictureBoxes[6].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[7].Tag.ToString() == CurrentPlayer.ToString() && pictureBoxes[8].Tag.ToString() == CurrentPlayer.ToString())
            {
                WhoWon = CurrentPlayer;
                return true;
            }


            return false; // if no winning condition is met, return false to indicate that the game should continue
        }


        void DisableControls()
        {
            groupBox1.Enabled = false; // disable the group box to prevent further interaction after the game has ended 
            btnRestart.Enabled = true; // enable the restart button to allow the user to start a new game
        }

        void EndGame(enCurrentPlayer whoWon)
        {
            DisableControls();
            label1.ForeColor = Color.DarkGreen;
            label1.Text = "Congratulations";

            if (WhoWon == enCurrentPlayer.Player1)
            {
                labCurrentPlayer.Font = new Font(labCurrentPlayer.Font, FontStyle.Bold); // make the label font bold to emphasize the win
                labCurrentPlayer.Text = "Player 1 Wins!";
              

            }
         
            else if (WhoWon == enCurrentPlayer.Player2)
            {
                labCurrentPlayer.Font = new Font(labCurrentPlayer.Font, FontStyle.Bold); // make the label font bold to emphasize the draw
                labCurrentPlayer.Text = "Player 2 Wins!";

            }
            btnRestart.Visible = true; // Disable the restart button until the game ends

        }

        void MadeDraw()
        {
            DisableControls();
            labCurrentPlayer.Font = new Font(labCurrentPlayer.Font, FontStyle.Bold); // make the label font bold to emphasize the draw
            labCurrentPlayer.ForeColor = Color.Yellow; // change the label color to yellow to indicate a draw   
            labCurrentPlayer.Text = "It's a Draw!";
            label1.ForeColor = Color.DarkGreen;
            label1.Text = "Game Over";
            btnRestart.Visible = true; // Disable the restart button until the game ends

        }

        void SetAllPictureBoxesToDefault()
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

            foreach (var item in pictureBoxes)
            {
                item.Tag = "";
                item.Image = Image.FromFile(@"E:\projects\C#\14 - C# - Level 1\Windows Forms\Tic-Tac-Toe2\Pics\QPixel.png");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are You Sure You Want Another Round?", "Restarting the game...", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) ;
           
            if (DialogResult.OK == res)
            {
                SetAllPictureBoxesToDefault();
                groupBox1.Enabled = true;
                label1.Text = "Current Player";
                labCurrentPlayer.Text = "Player1";
                labCurrentPlayer.ForeColor=Color.White;
                btnRestart.Enabled = false;
              
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; // Enable the group box to allow interaction
            btnRestart.Visible = false; // Disable the restart button until the game ends
        }
    }

}
