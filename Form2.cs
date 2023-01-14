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

    public partial class Form2 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = MyDatabase.mdb";
        private OleDbConnection myConnection;
        
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_student_bilet = Convert.ToInt32(textBox1.Text);
            string FIO = textBox2.Text;
            string POL = textBox3.Text;
            string DATA = textBox4.Text;
            string number_roditelya = textBox5.Text;
            string number_studenta = textBox6.Text;
            string adress = textBox8.Text;
            int number_zachet_book = Convert.ToInt32(textBox7.Text);
            string query = "INSERT INTO Students (Номер_студенческого_билета, ФИО, Пол, Дата_рождения, Адрес_проживания, Телефон_студента, Телефон_родителя, Номер_зачётной_книги) VALUES("+ number_student_bilet + ",'"+FIO+"','"+POL+"','"+DATA+"','"+adress+"','"+number_studenta+"','"+number_roditelya+"',"+number_zachet_book+")";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о студенте добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
