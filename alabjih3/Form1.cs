using System.IO;
using Npgsql;

namespace alabjih3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            path = file.FileName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                NpgsqlConnection connect = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string query = "insert into data_ab(" +
                    "id, surname, name, patronymic,level_edu,coins_edu,snils,seria,number_pass,when_pass," +
                    "how_pass,phone,email,path_edu,address_pass,institut) values " +
                    "(@id, @surname, @name, @patronymic,@level_edu,@coins_edu,@snils,@seria,@number_pass," +
                    "@when_pass,@how_pass,@phone,@email,@path_edu,@address_pass,@institut)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@surname", textBox2.Text);
                cmd.Parameters.AddWithValue("@name", textBox3.Text);
                cmd.Parameters.AddWithValue("@patronymic", textBox4.Text);
                cmd.Parameters.AddWithValue("@level_edu", comboBox7.Text);
                cmd.Parameters.AddWithValue("@coins_edu", Convert.ToInt32(textBox5.Text));
                cmd.Parameters.AddWithValue("@snils", textBox13.Text);
                cmd.Parameters.AddWithValue("@seria", textBox6.Text);
                cmd.Parameters.AddWithValue("@number_pass", textBox7.Text);
                cmd.Parameters.AddWithValue("@when_pass", textBox8.Text);
                cmd.Parameters.AddWithValue("@how_pass", textBox10.Text);
                cmd.Parameters.AddWithValue("@phone", textBox11.Text);
                cmd.Parameters.AddWithValue("@email", textBox12.Text);
                cmd.Parameters.AddWithValue("@path_edu", path);
                cmd.Parameters.AddWithValue("@address_pass", textBox14.Text);
                cmd.Parameters.AddWithValue("@institut", textBox15.Text);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();

                NpgsqlConnection con = new NpgsqlConnection("Host=localhost; Username=postgres; Password=780213; Database=R7-034");
                string sql = "insert into login_password(" +
                    "id, login, password, status) values " +
                    "(@id, @login, @password, @status)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                command.Parameters.AddWithValue("@login", textBox16.Text);
                command.Parameters.AddWithValue("@password", textBox17.Text);
                command.Parameters.AddWithValue("@status", "����������");
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Applicant employee = new Applicant(textBox16.Text, textBox17.Text);
            employee.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox2.Text, textBox3.Text, textBox4.Text,
                comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text);
            form2.ShowDialog();
        }

        private void comboBox8_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "���")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("��������� ���������������� ���������� � ��������");
                comboBox2.Items.Add("������������� � ������������ ������ � ����������");
                comboBox2.Items.Add("������������� � ������������ ������������� ����� � ����������");
                comboBox2.Items.Add("������ � ������������ ������������ � ������ �������������");
                comboBox2.Items.Add("������ � ����������� ���������� �������������� ���������, ����������������� ������� � ����������");
                comboBox2.Items.Add("������������ ������� � ���������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("�����������");
                comboBox2.Items.Add("������������� � ����������� �������������� ��������");
                comboBox2.Items.Add("������ ������������� �����");
                comboBox2.Items.Add("������������������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("�������������� ������������ �������������������� ������");
                comboBox2.Items.Add("���������������� ������� � ���������");
                comboBox2.Items.Add("�������������� ����������� � �������� ����������");
                comboBox2.Items.Add("�������- � ����������������");
            }
            if (comboBox7.Text == "������������")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("�����������");
                comboBox2.Items.Add("������������� � ����������� �������������� ��������");
                comboBox2.Items.Add("������ ������������� �����");
            }
        }

        private void comboBox9_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "���")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("��������� ���������������� ���������� � ��������");
                comboBox3.Items.Add("������������� � ������������ ������ � ����������");
                comboBox3.Items.Add("������������� � ������������ ������������� ����� � ����������");
                comboBox3.Items.Add("������ � ������������ ������������ � ������ �������������");
                comboBox3.Items.Add("������ � ����������� ���������� �������������� ���������, ����������������� ������� � ����������");
                comboBox3.Items.Add("������������ ������� � ���������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("�����������");
                comboBox3.Items.Add("������������� � ����������� �������������� ��������");
                comboBox3.Items.Add("������ ������������� �����");
                comboBox3.Items.Add("������������������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("�������������� ������������ �������������������� ������");
                comboBox3.Items.Add("���������������� ������� � ���������");
                comboBox3.Items.Add("�������������� ����������� � �������� ����������");
                comboBox3.Items.Add("�������- � ����������������");
            }
            if (comboBox7.Text == "������������")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("�����������");
                comboBox3.Items.Add("������������� � ����������� �������������� ��������");
                comboBox3.Items.Add("������ ������������� �����");
            }
        }

        private void comboBox10_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "���")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("��������� ���������������� ���������� � ��������");
                comboBox4.Items.Add("������������� � ������������ ������ � ����������");
                comboBox4.Items.Add("������������� � ������������ ������������� ����� � ����������");
                comboBox4.Items.Add("������ � ������������ ������������ � ������ �������������");
                comboBox4.Items.Add("������ � ����������� ���������� �������������� ���������, ����������������� ������� � ����������");
                comboBox4.Items.Add("������������ ������� � ���������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("�����������");
                comboBox4.Items.Add("������������� � ����������� �������������� ��������");
                comboBox4.Items.Add("������ ������������� �����");
                comboBox4.Items.Add("������������������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("�������������� ������������ �������������������� ������");
                comboBox4.Items.Add("���������������� ������� � ���������");
                comboBox4.Items.Add("�������������� ����������� � �������� ����������");
                comboBox4.Items.Add("�������- � ����������������");
            }
            if (comboBox7.Text == "������������")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("�����������");
                comboBox4.Items.Add("������������� � ����������� �������������� ��������");
                comboBox4.Items.Add("������ ������������� �����");
            }

        }

        private void comboBox11_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "���")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("��������� ���������������� ���������� � ��������");
                comboBox5.Items.Add("������������� � ������������ ������ � ����������");
                comboBox5.Items.Add("������������� � ������������ ������������� ����� � ����������");
                comboBox5.Items.Add("������ � ������������ ������������ � ������ �������������");
                comboBox5.Items.Add("������ � ����������� ���������� �������������� ���������, ����������������� ������� � ����������");
                comboBox5.Items.Add("������������ ������� � ���������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("�����������");
                comboBox5.Items.Add("������������� � ����������� �������������� ��������");
                comboBox5.Items.Add("������ ������������� �����");
                comboBox5.Items.Add("������������������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("�������������� ������������ �������������������� ������");
                comboBox5.Items.Add("���������������� ������� � ���������");
                comboBox5.Items.Add("�������������� ����������� � �������� ����������");
                comboBox5.Items.Add("�������- � ����������������");
            }
            if (comboBox7.Text == "������������")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("�����������");
                comboBox5.Items.Add("������������� � ����������� �������������� ��������");
                comboBox5.Items.Add("������ ������������� �����");
            }
        }

        private void comboBox12_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "���")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("��������� ���������������� ���������� � ��������");
                comboBox6.Items.Add("������������� � ������������ ������ � ����������");
                comboBox6.Items.Add("������������� � ������������ ������������� ����� � ����������");
                comboBox6.Items.Add("������ � ������������ ������������ � ������ �������������");
                comboBox6.Items.Add("������ � ����������� ���������� �������������� ���������, ����������������� ������� � ����������");
                comboBox6.Items.Add("������������ ������� � ���������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("�����������");
                comboBox6.Items.Add("������������� � ����������� �������������� ��������");
                comboBox6.Items.Add("������ ������������� �����");
                comboBox6.Items.Add("������������������");
            }
            if (comboBox7.Text == "�����������")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("�������������� ������������ �������������������� ������");
                comboBox6.Items.Add("���������������� ������� � ���������");
                comboBox6.Items.Add("�������������� ����������� � �������� ����������");
                comboBox6.Items.Add("�������- � ����������������");
            }
            if (comboBox7.Text == "������������")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("�����������");
                comboBox6.Items.Add("������������� � ����������� �������������� ��������");
                comboBox6.Items.Add("������ ������������� �����");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
