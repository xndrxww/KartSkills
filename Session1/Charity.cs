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
    public partial class Charity : Form
    {

        string connectionString = @"Data Source=LAPTOP-VAME4LJ4\KUZNETSOV;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=3232";


        public Charity()
        {
            InitializeComponent();

            string racerSql = "Select * from Charity";
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(racerSql, connection);
                adapter.Fill(dataSet);
            }
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(new CharityCustom(dataSet.Tables[0].Rows[i].Field<string>("Charity_Name"), dataSet.Tables[0].Rows[i].Field<string>("Charity_Description"), dataSet.Tables[0].Rows[i].Field<string>("Charity_Logo")));
            }
        }
    }
}
