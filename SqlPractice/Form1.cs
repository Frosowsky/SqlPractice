using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = "Data Source=DESKTOP-1NUMHB5\\SQLEXPRESS01;Initial Catalog=MyFirstProject;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

     

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values (@imie, @nazwisko, @email)", con);
            cmd.Parameters.AddWithValue("@imie", NameBox.Text);
            cmd.Parameters.AddWithValue("@nazwisko", SurnameBox.Text);
            cmd.Parameters.AddWithValue("@email", EmailBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"Użytkownik {NameBox.Text} został dodany do bazy");
        }
    }
}
