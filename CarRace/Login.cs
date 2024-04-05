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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.username = txusn.Text;
            acc.password = txpass.Text;
            if (acc.Login())
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
