using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1
{
    public partial class Form1 : Form
    {
        string commandText;
        OleDbConnection conn;
        OleDbCommand MyCommand;
        OleDbDataAdapter dataAdapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=DBTur_firm.mdb";
            conn = new OleDbConnection(ConnectionString);
        }

        void Tourists()
        {
            commandText = "SELECT * FROM Туристы";
            conn.Open();
            MyCommand = new OleDbCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            ds = new DataSet();
            dataAdapter.Fill(ds, "Туристы");
            dataGridView1.DataSource = ds.Tables["Туристы"].DefaultView;
            conn.Close();
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tourists();
        }

        void Tours()
        {
            commandText = "SELECT * FROM Туры";
            conn.Open();
            MyCommand = new OleDbCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            ds = new DataSet();
            dataAdapter.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables["Туры"].DefaultView;
            conn.Close();
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Туристы (Фамилия,Имя,Отчество) values (@fName,@lName,@pName)";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@fName", "Шмель");
            MyCommand.Parameters.AddWithValue("@lName", "Елена");
            MyCommand.Parameters.AddWithValue("@pName", "Андреевна");
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tourists();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Update Туристы Set Фамилия=@fName,Имя=@lName,Отчество=@pName Where Код_туриста=@id";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@fName", "Иванов");
            MyCommand.Parameters.AddWithValue("@lName", "Григорий");
            MyCommand.Parameters.AddWithValue("@pName", "Валентинович");
            MyCommand.Parameters.AddWithValue("@id", 1);
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tourists();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete From Туры Where Код_тура=@id";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tours();
        }
    }
}
