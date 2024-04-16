using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace alabjih3
{
    public partial class Applicant : Form
    {
        public string login;
        public string password;
        public string surname;
        public string name;
        public string patronymic;

        public Applicant(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }

        private void Applicant_Load(object sender, EventArgs e)
        {

            try
            {
                NpgsqlConnection connect = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query = "select id from login_password where login=@login and password=@password";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                connect.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                connect.Close();

                NpgsqlConnection contact = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query2 = "select surname from data_ab where id=@id";
                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, contact);
                cmd2.Parameters.AddWithValue("@id", id);
                contact.Open();
                surname = cmd2.ExecuteScalar().ToString();
                contact.Close();

                NpgsqlConnection con = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query3 = "select name from data_ab where id=@id";
                NpgsqlCommand cmd3 = new NpgsqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@id", id);
                con.Open();
                name = cmd3.ExecuteScalar().ToString();
                con.Close();

                NpgsqlConnection connaction = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query4 = "select patronymic from data_ab where id=@id";
                NpgsqlCommand cmd4 = new NpgsqlCommand(query4, connaction);
                cmd4.Parameters.AddWithValue("@id", id);
                connaction.Open();
                patronymic = cmd4.ExecuteScalar().ToString();
                connaction.Close();

                label2.Text = surname + " " + name + " " + patronymic;

                NpgsqlConnection connecting = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query5 = "select status from status_letter where id=@id";
                NpgsqlCommand cmd5 = new NpgsqlCommand(query5, connecting);
                cmd5.Parameters.AddWithValue("@id", id);
                connecting.Open();
                status.Text = cmd5.ExecuteScalar().ToString();
                connecting.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Applicant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
