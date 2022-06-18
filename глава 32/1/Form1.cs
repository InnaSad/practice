using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand myCommand;
        OleDbDataAdapter dataAdapter;
        string commandText;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBTur_firm.mdb";
            conn = new OleDbConnection(connectionString);
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM Туристы";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsTourists = new DataSet();
            DataTable dtTourists = dsTourists.Tables.Add("Туристы");
            DataColumn dсIDtourist = dtTourists.Columns.Add("Код_туриста", typeof(Int32));
            dсIDtourist.Unique = true;
            DataColumn dcSurame = dtTourists.Columns.Add("Фамилия");
            DataColumn dcName = dtTourists.Columns.Add("Имя");
            DataColumn dcPatronymic = dtTourists.Columns.Add("Отчество");
            conn.Open();
            dataAdapter.Fill(dsTourists.Tables["Туристы"]);
            conn.Close();
            dataGridView1.DataSource = dsTourists.Tables["Туристы"].DefaultView;
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM Туры";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsTours = new DataSet();
            DataTable dtTours = dsTours.Tables.Add("Туры");
            DataColumn dсIDtour = dtTours.Columns.Add("Код_тура", typeof(Int32));
            dсIDtour.Unique = true;
            DataColumn dcName = dtTours.Columns.Add("Название");
            DataColumn dcPrice = dtTours.Columns.Add("Цена", typeof(Decimal));
            DataColumn dcInformation = dtTours.Columns.Add("Информация");
            conn.Open();
            dataAdapter.Fill(dsTours.Tables["Туры"]);
            conn.Close();
            dataGridView1.DataSource = dsTours.Tables["Туры"].DefaultView;
        }

        private void информацияОТуристахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM [Информация о туристах]";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsInformation = new DataSet();
            DataTable dtInformation = dsInformation.Tables.Add("Информация о туристах");
            DataColumn dсIDtourist = dtInformation.Columns.Add("Код туриста", typeof(Int32));
            dсIDtourist.Unique = true;
            DataColumn dcPassport = dtInformation.Columns.Add("Серия паспорта");
            DataColumn dcCity = dtInformation.Columns.Add("Город");
            DataColumn dcCountry = dtInformation.Columns.Add("Страна");
            DataColumn dcPhone = dtInformation.Columns.Add("Телефон");
            DataColumn dсIndex = dtInformation.Columns.Add("Индекс", typeof(Int32));
            conn.Open();
            dataAdapter.Fill(dsInformation.Tables["Информация о туристах"]);
            conn.Close();
            dataGridView1.DataSource = dsInformation.Tables["Информация о туристах"].DefaultView; 
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM Путевки";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsTravel = new DataSet();
            DataTable dtTravel = dsTravel.Tables.Add("Путевки");
            DataColumn dсIDtravel = dtTravel.Columns.Add("Код путевки", typeof(Int32));
            dсIDtravel.Unique = true;
            DataColumn dcIDtourist = dtTravel.Columns.Add("Код туриста", typeof(Int32));
            dcIDtourist.Unique = true;
            DataColumn dcIDSeason = dtTravel.Columns.Add("Код сезона", typeof(Int32));
            dcIDSeason.Unique = true;
            conn.Open();
            dataAdapter.Fill(dsTravel.Tables["Путевки"]);
            conn.Close();
            dataGridView1.DataSource = dsTravel.Tables["Путевки"].DefaultView;
        }

        private void сезоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM Сезоны";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsSeason = new DataSet();
            DataTable dtSeason = dsSeason.Tables.Add("Сезоны");
            DataColumn dсIDseason = dtSeason.Columns.Add("Код сезона", typeof(Int32));
            dсIDseason.Unique = true;
            DataColumn dcIDtour = dtSeason.Columns.Add("Код тура", typeof(Int32));
            dcIDtour.Unique = true;
            DataColumn dcDateOfStart = dtSeason.Columns.Add("Дата начала", typeof(DateTime));
            DataColumn dcDateOfEnd = dtSeason.Columns.Add("Дата конца", typeof(DateTime));
            DataColumn dcSeasonClose = dtSeason.Columns.Add("Сезон закрыт", typeof(Boolean));
            DataColumn dсNumber = dtSeason.Columns.Add("Количество мест", typeof(Int32));
            conn.Open();
            dataAdapter.Fill(dsSeason.Tables["Сезоны"]);
            conn.Close();
            dataGridView1.DataSource = dsSeason.Tables["Сезоны"].DefaultView;
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = "SELECT * FROM Оплата";
            myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            DataSet dsPayment = new DataSet();
            DataTable dtPayment = dsPayment.Tables.Add("Оплата");
            DataColumn dсIDpayment = dtPayment.Columns.Add("Код оплаты", typeof(Int32));
            dсIDpayment.Unique = true;
            DataColumn dcIDtravel = dtPayment.Columns.Add("Код путевки", typeof(Int32));
            dcIDtravel.Unique = true;
            DataColumn dcDateOfPayment = dtPayment.Columns.Add("Дата оплаты", typeof(DateTime));
            DataColumn dcSumma = dtPayment.Columns.Add("Сумма", typeof(Decimal));
            conn.Open();
            dataAdapter.Fill(dsPayment.Tables["Оплата"]);
            conn.Close();
            dataGridView1.DataSource = dsPayment.Tables["Оплата"].DefaultView;
        }
    }
}
