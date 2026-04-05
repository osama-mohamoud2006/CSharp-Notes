using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Refactored_Ver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }


        bool CheckWinnerOrNot(Button btn1 , Button btn2 , Button btn3)
        {
            // By default the tag is '?'
            if(btn1.Tag.ToString()=="?" && btn2.Tag.ToString() == "?" && btn3.Tag.ToString() == "?")
            {
                return false; 
            }
            else if(btn1.Tag.ToString() == btn2.Tag.ToString()&& btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                return true; 
            }
            return false;
        }


        void DetermineTheWinnerFromSelectedBtns()
        {
            if (CheckWinnerOrNot(button1, button4, button7)) //1
                return;

            if (CheckWinnerOrNot(button2, button5, button7))
                return;
        }


        void ChangeImage(Button btn)
        {
            switch(PlayerTurn)
            {
                // Game will start with player 1  --> x
                case enPlayer.Player1:
                    {
                        lblTurn.Text = PlayerTurn.ToString(); // change the current player label 
                        btn.Tag = "X";

                        break;
                    }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChangeImage(btn);
        }


    }
}
