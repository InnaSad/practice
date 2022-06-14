using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2
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
            g.DrawEllipse(p, 20, 20, 130, 130);
            g.DrawEllipse(p, 30, 30, 110, 110);
            g.DrawEllipse(p, 50, 50, 70, 70);
        }
    }
}
