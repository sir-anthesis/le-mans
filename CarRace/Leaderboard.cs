using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Leaderboard : Form
    {
        private Connection connection = new Connection();
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            try
            {
                connection.OpenCon();

                string query = "SELECT acc_name, car_name, score FROM tb_leaderboard ORDER BY score DESC";
                SqlCommand command = new SqlCommand(query, connection.con);
                SqlDataReader reader = command.ExecuteReader();
                int rank = 1;

                while (reader.Read())
                {
                    
                    string accName = reader["acc_name"].ToString();
                    string carName = reader["car_name"].ToString();
                    int score = Convert.ToInt32(reader["score"]);

                    dgldb.Rows.Add(rank, accName, carName, score);
                    rank++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.CloseCon();
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
