using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGaemForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Wire up the Paint event to draw the lines
            groupBox1.Paint += groupBox1_Paint;
        }

    

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Red;
        }

    
     // Add this method to handle drawing the Tic-Tac-Toe grid
     private void groupBox1_Paint(object sender, PaintEventArgs e)
                {
                    // Configure the pen (Color, Size)
                    using (Pen pen = new Pen(Color.Black, 5))
                    {
                        // Smooth the drawn lines
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        // Dynamically calculate gaps between the picture boxes
                        int vLine1X = pictureBox1.Right + (pictureBox2.Left - pictureBox1.Right) / 2;
                        int vLine2X = pictureBox2.Right + (pictureBox3.Left - pictureBox2.Right) / 2;
                
                        int hLine1Y = pictureBox1.Bottom + (pictureBox4.Top - pictureBox1.Bottom) / 2;
                        int hLine2Y = pictureBox4.Bottom + (pictureBox5.Top - pictureBox4.Bottom) / 2;

                        // Padding so the lines extend slightly past the picture boxes
                        int margin = 10;
                        int startX = pictureBox1.Left - margin;
                        int endX = pictureBox3.Right + margin;
                        int startY = pictureBox1.Top - margin;
                        int endY = pictureBox5.Bottom + margin; 

                        // Draw Vertical Lines
                        e.Graphics.DrawLine(pen, vLine1X, startY, vLine1X, endY);
                        e.Graphics.DrawLine(pen, vLine2X, startY, vLine2X, endY);

                        // Draw Horizontal Lines
                        e.Graphics.DrawLine(pen, startX, hLine1Y, endX, hLine1Y);
                        e.Graphics.DrawLine(pen, startX, hLine2Y, endX, hLine2Y);
                    }
                }


    }
}
