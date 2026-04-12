using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static byte conter =0;  

        struct stdata
        {
            public string name;
            public int age;

            public override string ToString()
            {
                return $"{name},{age}";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stdata d;
            d.name = "Ahmed";
            d.age = 20;
                
            treeView1.Nodes.Add(d.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(treeView1.Nodes.Count<1) )
            treeView1.Nodes.RemoveAt(treeView1.Nodes.Count-1 );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add("Child " + conter++) ;
        }

        private void treeView1_Click(object sender, EventArgs e) // Node 
        {
            this.BackColor = Color.AliceBlue;
            //  MessageBox.Show("Node Clicked") ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) // Child 
        {
            if(treeView1.SelectedNode.Nodes!=null) // The Child Of The Current Selected Node
                MessageBox.Show(treeView1.SelectedNode.Nodes.Text );
        }
    }
}
