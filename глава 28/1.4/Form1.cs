using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4
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
            int side = 40;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    Brush col = (i + j) % 2 != 0 ? Brushes.Black : Brushes.White;
                    g.FillRectangle(col, i * side, j * side, side, side);
                }
        }
    }
}
