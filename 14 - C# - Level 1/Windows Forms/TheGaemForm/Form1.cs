using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; // Enable the group box to allow interaction
            btnStart.Enabled = false; // Disable the start button to prevent multiple clicks
        }


        enum enCurrentPlayer : byte
        {   none=0,
            Player1=1,
            Player2=2
        }

        // player 1 --> O
        // player 2 --> X
         enCurrentPlayer currentPlayer = enCurrentPlayer.none;
         enCurrentPlayer prevPlayer = enCurrentPlayer.none;

        void PictureBoxClick(enCurrentPlayer CurrenPlayer, PictureBox Currentpb)
        {
            switch(CurrenPlayer)
            {
                case enCurrentPlayer.Player1:
                    Currentpb.Image = Resources.O;
                    break;

            }
        }

        void CurrentPlayerChange(object sender)
        {
            currentPlayer=enCurrentPlayer.Player1;

            PictureBox pb = (PictureBox) sender;


        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
          
        }
    }
}
