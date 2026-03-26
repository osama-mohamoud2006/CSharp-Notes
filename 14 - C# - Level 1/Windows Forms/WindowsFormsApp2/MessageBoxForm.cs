using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world this is normal message box");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is Text", "This Is Caption");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("text", "title", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                MessageBox.Show("pressed ok");
            }
            else
            {
                MessageBox.Show("pressed cancel");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // var res = MessageBox.Show("HELLO !","test dialog options",MessageBoxButtons.YesNoCancel); ( implicitly typed local variables)
            DialogResult res = MessageBox.Show("HELLO !", "test dialog options", MessageBoxButtons.YesNoCancel,MessageBoxIcon.None); // enum 

            if (res == DialogResult.Yes)
            {
                MessageBox.Show("YES YES YES");
            }
            else if(res == DialogResult.No)
            {
                MessageBox.Show("NO NO NO");
            }
            else
            {
                MessageBox.Show("Cancel Cancel Cancel");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "title btw", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = 
          MessageBox.Show("Are You Sure About Closing The Form?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation
          ,MessageBoxDefaultButton.Button2,0,false);

            if (res == DialogResult.OK)
                this.Close();

            else MessageBox.Show("No Thing Has Happened", "لكي تطمئن");
        }
    }
}
