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

        double[] Mas = new double[25];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                Mas[i] = rand.NextDouble();
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Math.Round(Mas[i], 2));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            double min = Mas[0];
            for (int i = 0; i < Mas.Length; i++)
            {
                if (min > Mas[i])
                    min = Mas[i];
            }
            int index_min = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i] == min)
                    index_min = i;
            }
            double temp = Mas[0];
            Mas[index_min] = temp;
            Mas[0] = min;
            for (int i = 0; i < Mas.Length; i++)
                listBox2.Items.Add("Mas[" + i.ToString() + "] = " + Math.Round(Mas[i], 2));
        }
    }
}
