using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawEllipse(pen, 250, 10, 60, 60);
            g.DrawLine(pen, 280, 70, 280, 200);
            g.DrawLine(pen, 350, 140, 210, 140);
            g.DrawLine(pen, 280, 200, 330, 250);
            g.DrawLine(pen, 280, 200, 230, 250);
        }
    }
}
