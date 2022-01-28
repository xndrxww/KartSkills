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
    public partial class Authhorization : Form
    {
        string connectionString = @"Data Source=LAPTOP-VAME4LJ4\KUZNETSOV;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=3232";
        DataSet dataSet = new DataSet();
        public Authhorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUser();

            if (dataSet.Tables[0].Rows.Count != 0)
            {
                if (dataSet.Tables[0].Rows[0].Field<string>("ID_Role") == "R")
                {
                    RacerMenu racerMenu = new RacerMenu();
                    racerMenu.Show();
                    Close();
                }
                else if (dataSet.Tables[0].Rows[0].Field<string>("ID_Role") == "A")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    Close();
                }
                else if (dataSet.Tables[0].Rows[0].Field<string>("ID_Role") == "C")
                {
                    CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                    coordinatorMenu.Show();
                    Close();
                }
            }
            else { MessageBox.Show("Данные введены неверно"); }

            dataSet.Clear();
        }

        private void GetUser()
        {
            string sql = $"Select * from [User] where Email = '{emailText.Text}' and Password = '{passwordText.Text}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dataSet);
            }
        }
    }
}
