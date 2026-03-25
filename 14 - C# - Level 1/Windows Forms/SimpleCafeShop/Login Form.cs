using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCafeShop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void MouseEnteredAccNum(object sender, EventArgs e)
        {
            txtAccNum.BackColor = Color.WhiteSmoke;
        }

        private void MouseLeftAccNum(object sender, EventArgs e)
        {
            txtAccNum.BackColor = Color.Gainsboro;
        }

        private void MouseEnteredPass(object sender, EventArgs e)
        {
            txtAccPass.BackColor = Color.WhiteSmoke;
        }

        private void MouseLeftPass(object sender, EventArgs e)
        {
            txtAccPass.BackColor = Color.Gainsboro;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MainScreen main = new MainScreen();
            //main.ShowDialog();
            this.Close(); // to close the current form 
        }
    }
}
