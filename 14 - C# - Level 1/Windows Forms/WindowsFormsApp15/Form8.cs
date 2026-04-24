using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Hello Description !"; //

            if ( folderBrowserDialog1.ShowDialog()==DialogResult.OK )
            {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
