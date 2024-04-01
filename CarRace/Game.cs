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

        public Game()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            MoveEnemy(gamespeed);
        }

        Random r = new Random();
        int x, y;

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


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && car.Left > 35)
            {
                car.Left += -10;
            }
            if (e.KeyCode == Keys.Right && car.Left < 700)
            {
                car.Left += 10;
            }
            if (e.KeyCode == Keys.Up && gamespeed < 10)
            {
                gamespeed++;
            }
            if (e.KeyCode == Keys.Down && gamespeed > 0)
            {
                gamespeed--;
            }
        }

    }
}
