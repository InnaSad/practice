using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
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
            Pen p = new Pen(Brushes.Black, 2);
            SolidBrush b = new SolidBrush(Color.Blue);
            g.DrawPolygon(p, new PointF[] { 
                new PointF(20, 20), 
                new PointF(100, 100), 
                new PointF(20, 100) });
            g.DrawEllipse(p, 120, 20, 120, 70);
            g.FillEllipse(b, 280, 20, 80, 80);
            g.FillRectangle(b, 20, 130, 100, 50);
            g.DrawPie(p, 60, 20, 180, 180, 0.0F, 60.0F);
        }
    }
}
