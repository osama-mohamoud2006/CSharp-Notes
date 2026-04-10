using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct Info
        {
            public string NameOfTask;
            public string DeadLine;
            public string CreatedWhen;
        }

        Info Task;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAdd InputForm = new frmAdd();
            InputForm.ShowDialog();

            Task.NameOfTask =InputForm.tbInput.Text; // the user input (from input form)

        }

      

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
