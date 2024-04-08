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
    public partial class Garage : Form
    {
        string images_path = "C:\\Users\\User\\source\\repos\\CarRace\\CarRace\\Resources\\";
        bool own;
        CarList cl = new CarList();
        Account ac = new Account();

        void CarClicked(string id_car) 
        {
            cl.id_car = id_car;
            if (cl.CarSelected())
            {
                btbuy.Text = "SELL";
                btuse.Visible = true;
                own = true;

                if (GlobalVariable.car_active == id_car)
                {
                    btuse.Text = "USED";
                    btuse.Enabled = false;
                }
                else
                {
                    btuse.Text = "USE";
                    btuse.Enabled = true;
                }
            }
            else
            {
                btbuy.Text = "BUY";
                btuse.Visible = false;
                own = false;
            }

            btbuy.Visible = true;
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
            lbcoins.Text = GlobalVariable.coins.ToString();
        }

        public Garage()
        {
            InitializeComponent();
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            CarClicked("CR1");
            btbuy.Visible = false;
        }

        private void pccr1_Click(object sender, EventArgs e)
        {
            CarClicked("CR1");
            btbuy.Visible = false;
        }

        private void pccr2_Click(object sender, EventArgs e)
        {
            CarClicked("CR2");
        }

        private void pccr3_Click(object sender, EventArgs e)
        {
            CarClicked("CR3");
        }

        private void pccr4_Click(object sender, EventArgs e)
        {
            CarClicked("CR4");
        }

        private void pccr5_Click(object sender, EventArgs e)
        {
            CarClicked("CR5");
        }

        private void btbuy_Click(object sender, EventArgs e)
        {
            if (own == true)
            {
                cl.SellCar();
                GlobalVariable.coins += cl.price;
                lbcoins.Text = GlobalVariable.coins.ToString();
                ac.UpdateCoins();
                CarClicked(cl.id_car);

                if (GlobalVariable.car_active == cl.id_car)
                {
                    GlobalVariable.car_active = "CR1";
                    ac.ActivingCar();
                }
            }
            else 
            {
                if (GlobalVariable.coins >= cl.price)
                {
                    cl.BuyCar();
                    GlobalVariable.coins -= cl.price;
                    lbcoins.Text = GlobalVariable.coins.ToString();
                    ac.UpdateCoins();
                    CarClicked(cl.id_car);
                }
                else
                {
                    MessageBox.Show("Your coins are not enough");
                }
            }
        }

        private void btuse_Click(object sender, EventArgs e)
        {
            GlobalVariable.car_active = cl.id_car;
            ac.ActivingCar();
            CarClicked(cl.id_car);

            if (cl.id_car == "CR1")
            {
                btbuy.Visible = false;
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }
    }
}
