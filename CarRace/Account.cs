using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRace
{
    internal class Account
    {
        public string email;
        public string username;
        public string name;
        public string password;
        public string car_thumb;
        public string car_px;
        public int car_speed;
        public string car_name;

        Connection connection = new Connection();

        public bool Register()
        {
            bool stat = false;
            connection.OpenCon();
            try 
            {
                string query = "INSERT INTO tb_account VALUES (@email, @username, @name, @password, @car, @coins)";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@password", password);
                com.Parameters.AddWithValue("@car", "CR1");
                com.Parameters.AddWithValue("@coins", 0);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Register Successfully");
                    stat = true;
                }
                else
                {
                    MessageBox.Show("Register Failed");
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
            return stat;
        }

        public bool Login()
        {
            bool stat = false;
            connection.OpenCon();
            try
            {
                string query = "SELECT * FROM tb_account WHERE username = @usn AND password = @pass";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@usn", username);
                com.Parameters.AddWithValue("@pass", password);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successfully");
                    GlobalVariable.id_acc = Convert.ToInt32(dr[0]);
                    GlobalVariable.name = dr[3].ToString();
                    GlobalVariable.coins = Convert.ToInt32(dr[6]);
                    GlobalVariable.car_active = dr[5].ToString();
                    dr.Close();
                    stat = true;
                }
                else
                {
                    MessageBox.Show("Your Username or Password are Incorrect");
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
            return stat;
        }

        public void Logout() 
        {
            GlobalVariable.id_acc = 0;
            GlobalVariable.name = "";
            GlobalVariable.coins = 0;
            GlobalVariable.car_active = "";
        }

        public void UpdateCoins() 
        {
            connection.OpenCon();
            try
            {
                string query = "UPDATE tb_account SET coins = @coins WHERE id_account = @id_account";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@coins", GlobalVariable.coins);
                com.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update Coin Successfully");
                }
                else
                {
                    MessageBox.Show("Update Coin Failed");
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

        public void ActivingCar() 
        {
            connection.OpenCon();
            try
            {
                string query = "UPDATE tb_account SET car_active = @car_active WHERE id_account = @id_account";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@car_active", GlobalVariable.car_active);
                com.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                com.ExecuteNonQuery();
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

        public void CarThumbnail()
        {
            connection.OpenCon();
            try
            {
                string query = "SELECT car_right, car_pixel, speed, car_name FROM tb_carlist WHERE id_car = @id_car";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@id_car", GlobalVariable.car_active);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    this.car_thumb = "C:\\Users\\User\\source\\repos\\CarRace\\CarRace\\Resources\\" + dr[0].ToString();
                    this.car_px = "C:\\Users\\User\\source\\repos\\CarRace\\CarRace\\Resources\\" + dr[1].ToString();
                    this.car_speed = Convert.ToInt32(dr[2]);
                    this.car_name = dr[3].ToString();
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

        public void AddHistory()
        {
            connection.OpenCon();
            try
            {
                string query = "INSERT INTO tb_history VALUES (@id_account, @id_car, @acc_name, @car_name, @score, @time)";
                SqlCommand com = new SqlCommand(query, connection.con);
                com.Parameters.AddWithValue("@id_account", GlobalVariable.id_acc);
                com.Parameters.AddWithValue("@id_car", GlobalVariable.car_active);
                com.Parameters.AddWithValue("@acc_name", GlobalVariable.name);
                com.Parameters.AddWithValue("@car_name", car_name);
                com.Parameters.AddWithValue("@score", Game.score);
                com.Parameters.AddWithValue("@time", DateTime.Now);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("History has been saved");
                }
                else
                {
                    MessageBox.Show("History Failed");
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
