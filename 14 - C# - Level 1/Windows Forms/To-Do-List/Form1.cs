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
            public string OgNameOfTask; // var to store the original string before editing (useless only 1 use case)
            public string DeadLine;
            public string CreatedWhen;
            public bool IsDone;

            public override string ToString()
            {
                return NameOfTask;
            }

        }

        stInfo InfoTask;

        private void Add_Click(object sender, EventArgs e)
        {
            frmAdd InputForm = new frmAdd();
            InputForm.ShowDialog();

            InfoTask.NameOfTask =InputForm.tbInput.Text; // the user input (from input form)
            InfoTask.CreatedWhen = DateTime.Now.ToString(); // record the date of creation 
            InfoTask.DeadLine = InputForm.dtDeadLine.Value.ToString("dd/MM/yyy"); // the dead line from add form

            AddTask(InfoTask); // add the task 
        }

       
        void AddTask(stInfo InfoTask)
        {
            //Tasks.Tag= InfoTask; //store info in tag 

            Tasks.Items.Add(InfoTask);
            
        }

        stInfo CurrentSelected; // the current selected task (struct)
        int index;
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox selected  = (CheckedListBox)sender;
          
             index = selected.SelectedIndex;
           if(index!=-1) CurrentSelected = (stInfo)selected.Items[index]; // take the selected index 
        }

        private void Info_Click(object sender, EventArgs e)
        {
            stInfo s = CurrentSelected;
            MessageBox.Show($"The Name Of Task : {s.NameOfTask}\n\n" +
                $"The Creation Time : {s.CreatedWhen}\n\n" +
                $"The Deadline : {s.DeadLine}");
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
          if(Tasks.Items.Count > 0)  Tasks.Items.RemoveAt(index); // remove task from screen (the selected index)
           
        }

        private string UnstrikeOutString(string str)
        {
            

            char [] c =  str.ToCharArray();
            string res = "";
            
            foreach (var item in c)
            {
                res+= item +"\u0336"; // to strike out text 
            }

            return res;
        }

        private void Tasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox currentTask = sender as CheckedListBox;

           

            stInfo temp = (stInfo)currentTask.Items[currentTask.SelectedIndex];

            if (!temp.IsDone) // isn't checked  --> checked 
            {
                temp.OgNameOfTask = temp.NameOfTask; // store the original text 
                temp.NameOfTask = UnstrikeOutString(temp.NameOfTask); // UnstrickenOut it 
                temp.IsDone = true;
                currentTask.Items[currentTask.SelectedIndex] = temp;
            }
            else // checked  --> Unchecked 
            {
                temp.NameOfTask =temp.OgNameOfTask; // return the Original before edit 
                temp.IsDone = false;
                currentTask.Items[currentTask.SelectedIndex] = temp;
            }

            Tasks.Refresh();

        }
    }


}
