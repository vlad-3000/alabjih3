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
                command.Parameters.AddWithValue("@status", "Абитуриент");
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
            if (comboBox7.Text == "СПО")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Монтажник радиоэлектронной аппаратуры и приборов");
                comboBox2.Items.Add("Строительство и эксплуатация зданий и сооружений");
                comboBox2.Items.Add("Строительство и эксплуатация автомобильных дорог и аэродромов");
                comboBox2.Items.Add("Монтаж и эксплуатация оборудования и систем газоснабжения");
                comboBox2.Items.Add("Монтаж и эксплутация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
                comboBox2.Items.Add("Компьютерные системы и комплексы");
            }
            if (comboBox7.Text == "Бакалавриат")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Архитектура");
                comboBox2.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox2.Items.Add("Дизайн архитектурной среды");
                comboBox2.Items.Add("Градостроительство");
            }
            if (comboBox7.Text == "Специалитет")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Информационная безопасность телекоммуникационных систем");
                comboBox2.Items.Add("Радиоэлектронные системы и комплексы");
                comboBox2.Items.Add("Проектирование авиационных и ракетных двигателей");
                comboBox2.Items.Add("Самолёто- и вертолётостроение");
            }
            if (comboBox7.Text == "Магистратура")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Архитектура");
                comboBox2.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox2.Items.Add("Дизайн архитектурной среды");
            }
        }

        private void comboBox9_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "СПО")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Монтажник радиоэлектронной аппаратуры и приборов");
                comboBox3.Items.Add("Строительство и эксплуатация зданий и сооружений");
                comboBox3.Items.Add("Строительство и эксплуатация автомобильных дорог и аэродромов");
                comboBox3.Items.Add("Монтаж и эксплуатация оборудования и систем газоснабжения");
                comboBox3.Items.Add("Монтаж и эксплутация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
                comboBox3.Items.Add("Компьютерные системы и комплексы");
            }
            if (comboBox7.Text == "Бакалавриат")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Архитектура");
                comboBox3.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox3.Items.Add("Дизайн архитектурной среды");
                comboBox3.Items.Add("Градостроительство");
            }
            if (comboBox7.Text == "Специалитет")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Информационная безопасность телекоммуникационных систем");
                comboBox3.Items.Add("Радиоэлектронные системы и комплексы");
                comboBox3.Items.Add("Проектирование авиационных и ракетных двигателей");
                comboBox3.Items.Add("Самолёто- и вертолётостроение");
            }
            if (comboBox7.Text == "Магистратура")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Архитектура");
                comboBox3.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox3.Items.Add("Дизайн архитектурной среды");
            }
        }

        private void comboBox10_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "СПО")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Монтажник радиоэлектронной аппаратуры и приборов");
                comboBox4.Items.Add("Строительство и эксплуатация зданий и сооружений");
                comboBox4.Items.Add("Строительство и эксплуатация автомобильных дорог и аэродромов");
                comboBox4.Items.Add("Монтаж и эксплуатация оборудования и систем газоснабжения");
                comboBox4.Items.Add("Монтаж и эксплутация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
                comboBox4.Items.Add("Компьютерные системы и комплексы");
            }
            if (comboBox7.Text == "Бакалавриат")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Архитектура");
                comboBox4.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox4.Items.Add("Дизайн архитектурной среды");
                comboBox4.Items.Add("Градостроительство");
            }
            if (comboBox7.Text == "Специалитет")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Информационная безопасность телекоммуникационных систем");
                comboBox4.Items.Add("Радиоэлектронные системы и комплексы");
                comboBox4.Items.Add("Проектирование авиационных и ракетных двигателей");
                comboBox4.Items.Add("Самолёто- и вертолётостроение");
            }
            if (comboBox7.Text == "Магистратура")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Архитектура");
                comboBox4.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox4.Items.Add("Дизайн архитектурной среды");
            }

        }

        private void comboBox11_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "СПО")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Монтажник радиоэлектронной аппаратуры и приборов");
                comboBox5.Items.Add("Строительство и эксплуатация зданий и сооружений");
                comboBox5.Items.Add("Строительство и эксплуатация автомобильных дорог и аэродромов");
                comboBox5.Items.Add("Монтаж и эксплуатация оборудования и систем газоснабжения");
                comboBox5.Items.Add("Монтаж и эксплутация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
                comboBox5.Items.Add("Компьютерные системы и комплексы");
            }
            if (comboBox7.Text == "Бакалавриат")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Архитектура");
                comboBox5.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox5.Items.Add("Дизайн архитектурной среды");
                comboBox5.Items.Add("Градостроительство");
            }
            if (comboBox7.Text == "Специалитет")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Информационная безопасность телекоммуникационных систем");
                comboBox5.Items.Add("Радиоэлектронные системы и комплексы");
                comboBox5.Items.Add("Проектирование авиационных и ракетных двигателей");
                comboBox5.Items.Add("Самолёто- и вертолётостроение");
            }
            if (comboBox7.Text == "Магистратура")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Архитектура");
                comboBox5.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox5.Items.Add("Дизайн архитектурной среды");
            }
        }

        private void comboBox12_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "СПО")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("Монтажник радиоэлектронной аппаратуры и приборов");
                comboBox6.Items.Add("Строительство и эксплуатация зданий и сооружений");
                comboBox6.Items.Add("Строительство и эксплуатация автомобильных дорог и аэродромов");
                comboBox6.Items.Add("Монтаж и эксплуатация оборудования и систем газоснабжения");
                comboBox6.Items.Add("Монтаж и эксплутация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
                comboBox6.Items.Add("Компьютерные системы и комплексы");
            }
            if (comboBox7.Text == "Бакалавриат")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("Архитектура");
                comboBox6.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox6.Items.Add("Дизайн архитектурной среды");
                comboBox6.Items.Add("Градостроительство");
            }
            if (comboBox7.Text == "Специалитет")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("Информационная безопасность телекоммуникационных систем");
                comboBox6.Items.Add("Радиоэлектронные системы и комплексы");
                comboBox6.Items.Add("Проектирование авиационных и ракетных двигателей");
                comboBox6.Items.Add("Самолёто- и вертолётостроение");
            }
            if (comboBox7.Text == "Магистратура")
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("Архитектура");
                comboBox6.Items.Add("Реконструкция и реставрация архитектурного наследия");
                comboBox6.Items.Add("Дизайн архитектурной среды");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
