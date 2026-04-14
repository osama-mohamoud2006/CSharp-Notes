using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Exercise_on_emp_management : Form
    {
        public Exercise_on_emp_management()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool CannotAdd()
        {
            return (String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbId.Text) ||
                String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPhone.Text)) ? false : true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CannotAdd())
            {
                return; 
            }
        }
    }
}
