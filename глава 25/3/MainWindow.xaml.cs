using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = Math.Tan(x[i]);
            }
            chart.ChartAreas.Add(new ChartArea("Default"));
            chart.Series.Add(new Series("y = tgx"));
            chart.Series["y = tgx"].ChartArea = "Default";
            chart.Series["y = tgx"].ChartType = SeriesChartType.Line;
            chart.ChartAreas[0].AxisX.Minimum = Xmin;
            chart.ChartAreas[0].AxisX.Maximum = Xmax;
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart.Series["y = tgx"].Points.DataBindXY(x, y);
        }
    }
}
