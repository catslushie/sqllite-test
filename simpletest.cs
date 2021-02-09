using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqltest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=c:\sqldemo\student.db;Version=3;FailIfMissing=False";

            string stm = "SELECT Name FROM Customer";

            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(stm, con);

 
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                MessageBox.Show($"{rdr.GetString(0)}");
            }

        }
    }
}
