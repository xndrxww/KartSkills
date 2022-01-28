using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Session1
{
    public partial class CharityCustom : UserControl
    {
        public CharityCustom(string name, string description, string picture)
        {
            InitializeComponent();
            nameLabel.Text = name;
            DescriptionLabel.Text = description;
            var random = new Random();

            if (File.Exists("CharityImages/" + picture))
            {
                picureBox.Image = Image.FromFile(@"CharityImages/" + picture);
            }
            else
            {
                string[] files = Directory.GetFiles("CharityImages");
                int value = random.Next(files.Length);
                picureBox.Image = Image.FromFile(files[value]);
            }
        }
    }
}
