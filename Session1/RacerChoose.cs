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
    public partial class RacerChoose : Form
    {
        public RacerChoose()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RacerRegistration racerRegistration = new RacerRegistration();
            racerRegistration.Show();
            Close();
        }
    }
}
