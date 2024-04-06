using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

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

        public void CarSelected() 
        {
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
                    MessageBox.Show(dr[1].ToString() + " is Selected");
                    dr.Close();
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
        }
    }
}
