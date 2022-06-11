using _1.Interfaces;
using _1.Share;
using _1.Models;
using Microsoft.Extensions.Logging;
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
using Microsoft.Win32;
using System.IO;

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder
                                                 .SetMinimumLevel(LogLevel.Information))
                                                 .CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindAirportDestination_Click(object sender, RoutedEventArgs e)
        {
            var airport = _worker.FindBy(textBoxAirportDestination.Text);
            PrintAirport(airport);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            PrintAirports(_worker.GetAll());
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxDeleteAirportDestination.Text)
                || !string.IsNullOrWhiteSpace(textBoxDeleteAirportDestination.Text))
            {
                _worker.Delete(textBoxDeleteAirportDestination.Text);
                PrintAirports(_worker.GetAll());
            }
        }

        private void PrintAirport(Airport airport)
        {
            textBlockXMLFileContent.Text = "=======Аэропорт======" + Environment.NewLine;
            textBlockXMLFileContent.Text += airport?.ToString() ?? "Рейс не найден";
        }

        private void PrintAirports(List<Airport> airports)
        {
            textBlockXMLFileContent.Text = "=======Аэропорты======" + Environment.NewLine;
            foreach(var airport in airports)
            {
                textBlockXMLFileContent.Text += airport.ToString();
            }
        }

        private void textBoxAirportDestination_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxAirportDestination.Text))
            {
                PrintAirports(_worker.GetAll());
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = " .xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if(result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintAirports(_worker.GetAll());
            }
        }
    }
}
