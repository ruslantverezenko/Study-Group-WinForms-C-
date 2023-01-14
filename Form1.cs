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
   
    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = MyDatabase.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDatabaseDataSet.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.myDatabaseDataSet.Grades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDatabaseDataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.myDatabaseDataSet.Parents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDatabaseDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.myDatabaseDataSet.Students);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_student_bilet = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Students WHERE Номер_студенческого_билета = " + number_student_bilet;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о студенте удалены");
            this.studentsTableAdapter.Fill(this.myDatabaseDataSet.Students);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number_student_bilet = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Students SET Адрес_проживания ='" + textBox3.Text + "' WHERE Номер_студенческого_билета = " + number_student_bilet;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Адрес студента обновлен");
            this.studentsTableAdapter.Fill(this.myDatabaseDataSet.Students);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.myDatabaseDataSet.Students);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.parentsTableAdapter.Fill(this.myDatabaseDataSet.Parents);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.gradesTableAdapter.Fill(this.myDatabaseDataSet.Grades);
        }
    }
}
