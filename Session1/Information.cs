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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Charity charity = new Charity();
            charity.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KartInformation kartInformation = new KartInformation();
            kartInformation.Show();
            Close();
        }
    }
}
