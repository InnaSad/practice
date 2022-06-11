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

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.MouseMove += Button_MouseMove;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            button.ClickMode = ClickMode.Hover;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button.ClickMode = ClickMode.Press;
            button.Visibility = Visibility.Collapsed;
        }
    }
}
