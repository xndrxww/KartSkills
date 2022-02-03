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
    public partial class RacerRegistration : Form
    {
        string connectionString = @"Data Source=LAPTOP-VAME4LJ4\KUZNETSOV;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=3232";
        DataSet dataSet = new DataSet();

        public RacerRegistration()
        {
            InitializeComponent();
            GetCountry();
            setGender();
        }

        private void InsertUser()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"Insert into dbo.[User] (Email, Password, First_Name, Last_Name, ID_Role) values('{emailText.Text}', '{passwordText.Text}', '{nameText.Text}', '{surnameText.Text}', 'R')", connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void InsertRacer()
        {
            string gender = genderBox.SelectedItem.ToString();
            if (gender == "Мужчина")
            {
                gender = "M";
            }
            else if (gender == "Женщина")
            {
                gender = "F";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"Insert into Racer (First_Name, Last_Name, Gender, DateOfBirth, ID_Country) values ('{nameText.Text}', '{surnameText.Text}', '{gender}', '{birthdayText.Text}', (select ID_Country from Country where Country_Name = '{countryBox.Text}'))", connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void GetCountry()
        {
            string sql = "Select * from Country";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
            }

            countryBox.DataSource = dataSet.Tables[0];
            countryBox.DisplayMember = "Country_Name";
        }

        

        private void setGender()
        {
            string[] gender = new string[] { "Мужчина", "Женщина" };
            genderBox.Items.AddRange(gender);
            genderBox.SelectedIndex = 0;
        }
        private void regButton_Click(object sender, EventArgs e)
        {
            InsertUser();
            InsertRacer();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                imageText.Text = fileName;
            }
        }
    }
}
