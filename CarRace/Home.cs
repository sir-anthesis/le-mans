using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Home : Form
    {
        Account acc = new Account();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            acc.CarThumbnail();
            pccar.Image = Image.FromFile(acc.car_thumb);
            lbuser.Text = GlobalVariable.name;
            lbcoins.Text = GlobalVariable.coins.ToString();
        }

        private void btgrg_Click(object sender, EventArgs e)
        {
            Garage gr = new Garage();
            this.Hide();
            gr.Show();
        }
    }
}
