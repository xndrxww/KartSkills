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
    public partial class RacerMenu : Form
    {
        public RacerMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContactInformation contactInformation = new ContactInformation();
            contactInformation.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RacerRegistration racerRegistration = new RacerRegistration();
            racerRegistration.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            Close();
        }
    }
}
