using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Tag.ToString();
            
        }

        struct Data
        {
           
            
            public string name ;
            public byte age;

        }
        Data temp ;
        private void button2_Click(object sender, EventArgs e)
        {
            temp.name = "osama";
            temp.age = 20;
            button2.Tag = temp;

            Data d = (Data)button2.Tag;

            label1.Text = d.name;
            label2.Text = d.age.ToString();
        }
    }
}
