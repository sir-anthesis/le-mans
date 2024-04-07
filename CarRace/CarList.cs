using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CarRace
{
    internal class CarList
    {
        public string id_car;
        public string car_name;
        public string car_right;
        public string car_left;
        public string car_pixel;
        public int speed;
        public int price;
        public string status;

        Connection connection = new Connection();

        public bool CarSelected() 
        {
            bool owned = false;
            connection.OpenCon();
            try
            {
                string query = "SELECT * FROM tb_carlist WHERE id_car = @id_car";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@id_car", id_car);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    car_name = dr[1].ToString();
                    car_right = dr[2].ToString();
                    car_left = dr[3].ToString();
                    speed = Convert.ToInt32(dr[5]);
                    price = Convert.ToInt32(dr[6]);
                    dr.Close();

                    string qown = "SELECT * FROM tb_carowned WHERE id_account = @id_account AND id_car = @id_car";
                    SqlCommand cown = new SqlCommand(qown, connection.con);
                    cown.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                    cown.Parameters.AddWithValue("@id_car", id_car);
                    SqlDataReader drown = cown.ExecuteReader();
                    if (drown.Read()) 
                    {
                        owned = true;
                    }
                }
                else
                {
                    MessageBox.Show("Selecting Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.CloseCon();
            }
            return owned;
        }

        public void BuyCar() 
        {
            connection.OpenCon();
            try
            {
                string query = "INSERT INTO tb_carowned VALUES (@id_account, @id_car, @car_name)";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                com.Parameters.AddWithValue("@id_car", id_car);
                com.Parameters.AddWithValue("@car_name", car_name);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Purchase Successfully");
                }
                else
                {
                    MessageBox.Show("Purchase Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.CloseCon();
            }
        }

        public void SellCar() 
        {
            connection.OpenCon();
            try
            {
                string query = "DELETE tb_carowned WHERE id_account = @id_account AND id_car = @id_car";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                com.Parameters.AddWithValue("@id_car", id_car);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Selling Successfully");
                }
                else
                {
                    MessageBox.Show("Selling Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.CloseCon();
            }
        }

    }
}
