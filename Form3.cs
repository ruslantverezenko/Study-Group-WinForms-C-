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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = MyDatabase.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number_roditelya = textBox1.Text;
            string FIO = textBox2.Text;
            string kem_yavlya_studentu = textBox3.Text;
            string mesto_raboti = textBox4.Text;
            

            string query = "INSERT INTO Parents (Телефон_родителя, ФИО, Кем_является_студенту, Место_работы) VALUES('" + number_roditelya + "','" + FIO + "','" + kem_yavlya_studentu + "','"+mesto_raboti+"')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о родителе добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
