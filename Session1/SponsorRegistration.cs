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

namespace Session1
{
    public partial class SponsorRegistration : Form
    {
        string connectionString = @"Data Source=LAPTOP-VAME4LJ4\KUZNETSOV;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=3232";

        public SponsorRegistration()
        {
            InitializeComponent();
            getComboBox();
        }

        private void getComboBox()
        {
            string racerSql = "Select First_Name, Last_Name from Racer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(racerSql, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "Last_Name";
            }
        }

        private bool Check()
        {
            bool ok = true;
            DateTime date = DateTime.Now;
            var period = new DateTime(int.Parse(textBox7.Text), int.Parse(textBox4.Text), 15, 12, 0, 0);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || textBox3.Text.Length != 16 || int.Parse(textBox4.Text) > 12 || int.Parse(textBox4.Text) < 1 || int.Parse(textBox7.Text) < 2022 || date > period || textBox5.Text.Length != 3)
            {
                MessageBox.Show("Поля заполнены неверно");
                ok = false;
            }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                SponsorAccess sponsorAccess = new SponsorAccess(comboBox1.Text, textBox6.Text);
                sponsorAccess.Show();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) < 10)
            {
                MessageBox.Show("Сумма пожертвования не может быть меньше 0");
            }
            else
            {
                int sum = int.Parse(textBox6.Text) - 10;
                textBox6.Text = sum.ToString();
                label16.Text = sum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox6.Text) + 10;
            textBox6.Text = sum.ToString();
            label16.Text = sum.ToString();
        }
    }
}
