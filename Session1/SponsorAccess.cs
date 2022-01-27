using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class SponsorAccess : Form
    {
        public SponsorAccess(string name = "", string sum = "")
        {
            InitializeComponent();
            label4.Text = name;
            label16.Text = sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SponsorRegistration sponsorRegistration = new SponsorRegistration();
            sponsorRegistration.Show();
            Close();
        }
    }
}
