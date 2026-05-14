using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Form2 frm = new Form2(); 
        private void button1_Click(object sender, EventArgs e)
        {
            //frm.IsDisposed is a property that checks whether a form or control has been disposed(destroyed) or not.
          if (frm==null || frm.IsDisposed )
            {
                frm = new Form2();
            }
            frm.MdiParent = this;
            frm.Show();


            //

            //if (this.IsMdiContainer) MessageBox.Show("Child of parent ");

           
            //foreach (var i in this.MdiChildren)
            //{
            //    MessageBox.Show($"The Children are :{i} "); 
            //}


          
        }
    } 
}
