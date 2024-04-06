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
        public Garage()
        {
            InitializeComponent();
        }

        CarList cl = new CarList();


        private void pccr1_Click(object sender, EventArgs e)
        {
            cl.id_car = "CR1";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }

        private void pccr2_Click(object sender, EventArgs e)
        {
            cl.id_car = "CR2";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }

        private void pccr3_Click(object sender, EventArgs e)
        {
            cl.id_car = "CR3";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }

        private void pccr4_Click(object sender, EventArgs e)
        {
            cl.id_car = "CR4";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }

        private void pccr5_Click(object sender, EventArgs e)
        {
            cl.id_car = "CR5";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            cl.id_car = "CR1";
            cl.CarSelected();
            pccr.Image = Image.FromFile(images_path + cl.car_left);
            lbcarname.Text = cl.car_name;
            lbprice.Text = cl.price.ToString();
        }
    }
}
