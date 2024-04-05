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
        int gamespeed = 0;
        Random r = new Random();
        int x, y;
        int score = 0;

        public Game()
        {
            InitializeComponent();
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
                if (coin.Top >= 700)
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
                    coin.Top = 0;
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
                    MessageBox.Show("Game Over");
                    MessageBox.Show("Your Score is " + this.score);
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && car.Left > 35)
            {
                car.Left += -20;
            }
            if (e.KeyCode == Keys.D && car.Left < 700)
            {
                car.Left += 20;
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
