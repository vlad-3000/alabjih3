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

namespace alabjih3
{
    public partial class Protection : Form
    {
        public Protection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 registry = new Form1();
            registry.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213;" +
                    "Database=R7-034");
                string query = "select status from login_password where password=@password and login=@login";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@login", textBox1.Text);
                con.Open();
                string status = (string)cmd.ExecuteScalar();
                con.Close();

                if (status == "Абитуриент")
                {
                    Applicant applicant = new Applicant(textBox1.Text, textBox2.Text);
                    applicant.ShowDialog();
                    this.Hide();
                }
                if (status == "Администратор")
                {
                    Employee employee = new Employee();
                    employee.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Protection_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}
