using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace CarRace
{
    public partial class Game : Form
    {
        int gamespeed;
        Random r = new Random();
        int x, y;
        public static int score;
        int carspeed;
        Account acc = new Account();

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            gamespeed = 1;
            acc.CarThumbnail();
            car.BackgroundImage = Image.FromFile(acc.car_px);
            this.carspeed = acc.car_speed;
            Game.score = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            MoveEnemy(gamespeed);
            MoveCoin(gamespeed);
            Scoring();
            GameOver();

            lbScore.Text = score.ToString();
        }

        void MoveEnemy(int speed) 
        {
            if (enemy1.Top >= 700)
            {
                x = r.Next(36, 256);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 700)
            {
                x = r.Next(257, 497);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 700)
            {
                x = r.Next(498, 718);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void MoveLine(int speed)
        {
            for (int i = 1; i <= 9; i++)
            {
                PictureBox lineBox = (PictureBox)this.Controls.Find("lineBox" + i, true)[0];

                if (lineBox.Top >= 700)
                {
                    lineBox.Top = -150;
                }
                else
                {
                    lineBox.Top += speed;
                }
            }
        }

        void MoveCoin(int speed) 
        {
            for (int i = 1; i <= 4; i++)
            {
                PictureBox coin = (PictureBox)this.Controls.Find("coin" + i, true)[0];
                if (coin.Top >= 700 || car.Bounds.IntersectsWith(coin.Bounds))
                {
                    x = r.Next(36, 718);
                    coin.Location = new Point(x, 0);
                }
                else
                {
                    coin.Top += speed;
                }
            }
        }

        void Scoring() 
        {
            for (int i = 1; i <= 4; i++)
            {
                PictureBox coin = (PictureBox)this.Controls.Find("coin" + i, true)[0];
                if (car.Bounds.IntersectsWith(coin.Bounds))
                {
                    score += 1;
                }
            }
        }

        void GameOver()
        {
            for (int i = 1; i <= 3; i++)
            {
                PictureBox enemy = (PictureBox)this.Controls.Find("enemy" + i, true)[0];
                if (car.Bounds.IntersectsWith(enemy.Bounds))
                {
                    timer1.Enabled = false;
                    GlobalVariable.coins += score;
                    acc.UpdateCoins();
                    acc.AddHistory();
                    MessageBox.Show("Your Score is " + score);
                    this.Hide();
                    Home hm = new Home();
                    hm.Show();
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && car.Left > 35)
            {
                car.Left -= carspeed;
            }
            if (e.KeyCode == Keys.D && car.Left < 700)
            {
                car.Left += carspeed;
            }
            if (e.KeyCode == Keys.W && gamespeed < 10)
            {
                gamespeed++;
            }
            if (e.KeyCode == Keys.S && gamespeed > 0)
            {
                gamespeed--;
            }
        }

    }
}
