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

namespace MyApp
{
    public partial class Form4 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = MyDatabase.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_zachetnoy_knigi = Convert.ToInt32(textBox1.Text);
            int mathematika = Convert.ToInt32(textBox2.Text);
            int russian_language = Convert.ToInt32(textBox3.Text);
            int physic = Convert.ToInt32(textBox4.Text);
            int informatic = Convert.ToInt32(textBox5.Text);

            string query = "INSERT INTO Grades (Номер_зачётной_книги, Математика, [Русский язык], Физика, Информатика) VALUES(" + number_zachetnoy_knigi + "," + mathematika + "," + russian_language + "," + physic +","+ informatic+")";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Оценки добавлены");
        }
    }
}
