using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y, y1;
        int i = 0, j = 0;
        SolidBrush B = new SolidBrush(Color.Blue);
        SolidBrush R = new SolidBrush(Color.DarkRed);
        SolidBrush U = new SolidBrush(Color.OrangeRed);
        Point[] T = new Point[4];
        Point[] L = new Point[7];

        private void Form1_Load(object sender, EventArgs e)
        {
            y = 220;
            x = 160;
            y1 = 256;
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (i == 1)
            {
                L[0] = new Point(x + 15, y1);
                L[1] = new Point(x + 10, y1 + 20);
                L[2] = new Point(x + 15, y1 + 15);
                L[3] = new Point(x + 20, y1 + 30);
                L[4] = new Point(x + 25, y1 + 15);
                L[5] = new Point(x + 30, y1 + 20);
                L[6] = new Point(x + 25, y1);
                g.FillPolygon(U, L);
            }
            T[0] = new Point(x + 20, y);
            T[1] = new Point(x, y + 50);
            T[2] = new Point(x + 20, y + 40);
            T[3] = new Point(x + 40, y + 50);
            g.FillPolygon(R, T);
            g.FillEllipse(B, x + 16, y + 15, 8, 8);
            g.FillEllipse(B, x + 16, y + 25, 8, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (j % 2 != 0)
                {
                    y1 += 3;
                }
                else
                    y1 -= 3;
                j++;
                y1 -= 3;
                y -= 3;
                Invalidate();
            }
        }
    }
}
