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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SponsorRegistration sponsorRegistration = new SponsorRegistration();
            sponsorRegistration.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }
    }
}
