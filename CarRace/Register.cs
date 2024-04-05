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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.email = txemail.Text;
            acc.username = txusn.Text;
            acc.name = txname.Text;
            acc.password = txpassword.Text;

            if (acc.Register())
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
