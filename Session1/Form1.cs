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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Authhorization authhorization = new Authhorization();
            authhorization.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RacerChoose racerChoose = new RacerChoose();
            racerChoose.Show();
        }
    }
}
