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

        private struct stInfo
        {
            public string NameOfTask;
            public string DeadLine;
            public string CreatedWhen;
        }

        stInfo Task;

        private void Add_Click(object sender, EventArgs e)
        {
            frmAdd InputForm = new frmAdd();
            InputForm.ShowDialog();

            Task.NameOfTask =InputForm.tbInput.Text; // the user input (from input form)
            Task.CreatedWhen = DateTime.Now.ToString(); // record the date of creation 
            Task.DeadLine = InputForm.dtDeadLine.Value.ToString("dd/MM/yyy"); // the dead line from add form

            AddTask(Task); // add the task 
        }

      
        void AddTask(stInfo Task)
        {
            Tasks.Items.Add(Task);
            Tasks.Items[0] = "v";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
