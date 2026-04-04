using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PaintingOnForm(object sender, PaintEventArgs e)
        {
            // create new pen
            Pen pen = new Pen(Color.Black, 10);
            
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 20, 20, 200, 20);

            e.Graphics.DrawRectangle(pen, 20, 50, 200, 100);

            e.Graphics.DrawEllipse(pen, 20, 200, 200, 150);
        }
    }
}
