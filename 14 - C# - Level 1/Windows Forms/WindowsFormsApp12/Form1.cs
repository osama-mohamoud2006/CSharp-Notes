using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes[0].ImageIndex = 0;



            treeView1.Nodes[1].ImageIndex = 1;
            treeView1.Nodes[2].ImageIndex = 2;
        

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
                
            treeView1.SelectedNode.Nodes.Add(d.ToString());
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
           ///  MessageBox.Show("Node Clicked") ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode!=null)
            MessageBox.Show(treeView1.SelectedNode.Text + " The Current Selected Node") ;
        }

    
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) // Child 
        {
           // if (treeView1.SelectedNode.Nodes != null) // The Child Of The Current Selected Node
              //  MessageBox.Show(treeView1.SelectedNode.Nodes[0].Text);

          ///  MessageBox.Show(treeView1.SelectedNode.Index.ToString());
            this.BackColor = Color.Red; 
        }

        // The TreeView Will Fire This Event 
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e) // true , false check status 
        {
            MessageBox.Show(treeView1.SelectedNode.Text + " Checked");

            // e --> is The Data Of The Current Event (the Node That Is Checked Or UnChecked)
            CheckUnCheckAll(e.Node,e.Node.Checked) // Call The Function To Check Or UnCheck All The Children Of The Current Node (e.Node) With The Check State Of The Current Node (e.Node.Checked)
             ;
        }

        private void CheckUnCheckAll(TreeNode Node , bool IsChecked) // this function takes node and toggle its check state and all its child nodes
         {
            /*
             Node -> Child 1 ==> Child 1.1
                  -> Child 1.2
             
             */
            //The Main Node Is Checked By User , So We Need To Check All Its Children

            foreach (TreeNode Item in Node.Nodes) //Check The Children of Current Node 
            {
                // Node --> Is The Main Node 
                Item.Checked = IsChecked; // The Event treeView1_AfterCheck If The CB Are Checked ==> Check All Node (the opposite is true) 


                // Check If There Are Children For The Current Node 
                if (Item.Nodes.Count > 0)
                {
                    CheckUnCheckAll(Item, IsChecked); // Recursive Call To Check The Children Of The Current Node
                }

            }
        }
      

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text + " Collapsed");
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode!=null) MessageBox.Show(treeView1.SelectedNode.Text + " Expanded"); 
        }






    }
}
