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
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=DBTur_firm.mdb";
            conn = new OleDbConnection(ConnectionString);
        }

        void GetTourists()
        {           
            conn.Open();
            da = new OleDbDataAdapter("SELECT *FROM Туристы", conn);
            ds = new DataSet();
            da.Fill(ds, "Туристы");
            dataGridView1.DataSource = ds.Tables["Туристы"];
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 132;
            conn.Close();
        }

        void GetTours()
        {
            conn.Open();
            da = new OleDbDataAdapter("SELECT *FROM Туры", conn);
            ds = new DataSet();
            da.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables["Туры"];
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 289;
            conn.Close();
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTourists();
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTours();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete From Туры Where Код_тура=@id";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetTours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Туристы (Фамилия,Имя,Отчество) values (@fName,@lName,@pName)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@fName", textBox2.Text);
            cmd.Parameters.AddWithValue("@lName", textBox3.Text);
            cmd.Parameters.AddWithValue("@pName", textBox4.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetTourists();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Update Туристы Set Фамилия=@fName,Имя=@lName,Отчество=@pName Where Код_туриста=@id";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@fName", textBox2.Text);
            cmd.Parameters.AddWithValue("@lName", textBox3.Text);
            cmd.Parameters.AddWithValue("@pName", textBox4.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetTourists();
        }
    }
}
