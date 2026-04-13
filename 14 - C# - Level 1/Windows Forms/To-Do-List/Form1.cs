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

        //int ValueToAddEachTimeToProgressBar = 0; // to determine what the progress bar should add each time 
        //private void UpdateValueToAddEachTimeToProgressBar()
        //{
        //    if(Tasks.Items.Count!=0)
        //    ValueToAddEachTimeToProgressBar = (100 / Tasks.Items.Count);

        //    progressBar1.Refresh();
        //}


        //private void AddToProgress()
        //{
        //    if (progressBar1.Value + ValueToAddEachTimeToProgressBar <= progressBar1.Maximum)
        //    {
        //        progressBar1.Value += (ValueToAddEachTimeToProgressBar);
        //        labProgress.Text = progressBar1.Value.ToString();
        //    }
        //    else // if the addition will > max to avoid value exceeds max 
        //    {
        //        progressBar1.Value = progressBar1.Maximum;
        //    }

        //}

        private void UpdateProgress()
        {
            progressBar1.Value = 0; // reset the progress bar to 0 before update it
            labProgress.Text = progressBar1.Value.ToString() + "%";

            int TheValOfEachTask = (100 / Tasks.Items.Count); // the value of each task in the progress bar

            foreach (var item in Tasks.Items)
            {
                stInfo temp = (stInfo)item;
                if(temp.IsDone)
                {
                    if (progressBar1.Value + TheValOfEachTask <= progressBar1.Maximum)
                    {
                        progressBar1.Value += TheValOfEachTask;
                        labProgress.Text = progressBar1.Value.ToString() + "%";
                    }
                    else // if the addition will > max to avoid value exceeds max 
                    {
                        progressBar1.Value = progressBar1.Maximum;
                        labProgress.Text = progressBar1.Value.ToString() + "%";
                    }
                }


                //else
                //{
                //    if (progressBar1.Value - TheValOfEachTask >= 0)
                //    {

                //        progressBar1.Value -= TheValOfEachTask;
                //        labProgress.Text = progressBar1.Value.ToString() + "%";
                //    }
                //    else if (0 > (progressBar1.Value - TheValOfEachTask))
                //    {
                //        progressBar1.Value = progressBar1.Minimum;
                //        labProgress.Text = "0%";
                //    }
                //}

            }

        }


        //private void RemoveFromProgress()
        //{
            //if (progressBar1.Value - ValueToAddEachTimeToProgressBar >= 0)
            //{
              
            //    progressBar1.Value -= ValueToAddEachTimeToProgressBar;
            //    labProgress.Text = progressBar1.Value.ToString();
            //}
            //else if (0 > (progressBar1.Value - ValueToAddEachTimeToProgressBar))
            //{
            //    progressBar1.Value = progressBar1.Minimum;
            //    labProgress.Text = "0%";
            //}
//}



        void AddTask(stInfo InfoTask)
        {
            //Tasks.Tag= InfoTask; //store info in tag 

            Tasks.Items.Add(InfoTask);
            UpdateProgress();


        }


        /*
         * The Index Change At runtime(by user-According To Selected Item) --> take this index to get the current item,remove or whatever
         */

        stInfo CurrentSelected; // the current selected task (struct)
        int index;
        private void checkedListBox_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox selected  = (CheckedListBox)sender;
          
             index = selected.SelectedIndex;
           if(index!=-1) CurrentSelected = (stInfo)selected.Items[index]; // take the selected index 
        }

        private bool NoThingOnListWaring()
        {
             if(Tasks.Items.Count==0)
            {
                MessageBox.Show("List Is Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return true;
            }
            return false;
        }

        private void Info_Click(object sender, EventArgs e)
        {

            if (NoThingOnListWaring()) return; 

            stInfo s = CurrentSelected; // the current selected item in the list 
            MessageBox.Show($"The Name Of Task : {s.NameOfTask}\n\n" +
                $"The Creation Time : {s.CreatedWhen}\n\n" +
                $"The Deadline : {s.DeadLine}");
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            if (NoThingOnListWaring()) return;

            if (Tasks.Items.Count > 0 && index != -1) // if there is tasks to delete and there is a selected task 
            {
                Tasks.Items.RemoveAt(index); // remove task from screen (the selected index)

                UpdateProgress();


            }
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

                UpdateProgress();
            }
            else // checked  --> Unchecked 
            {
                temp.NameOfTask =temp.OgNameOfTask; // return the Original before edit 
                temp.IsDone = false;
                currentTask.Items[currentTask.SelectedIndex] = temp;


                UpdateProgress();
            }

            //check if all tasks are un checked 
          
       

   

            Tasks.Refresh();
            progressBar1.Refresh();

        }




    }


}
