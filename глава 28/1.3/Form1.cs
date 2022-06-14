using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3
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
            Pen p = new Pen(Brushes.Black, 1);
            g.DrawRectangle(p, 10, 10, 40, 70);
            g.DrawRectangle(p, 30, 60, 40, 70);
            g.DrawRectangle(p, 50, 110, 40, 70);
            g.DrawRectangle(p, 70, 160, 40, 70);
            g.DrawRectangle(p, 90, 210, 40, 70);
        }
    }
}
