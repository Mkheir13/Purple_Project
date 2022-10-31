using System.Timers;
using System.Windows.Forms;

namespace Platform
{
    public partial class Form1 : Form
    {
        bool _right, _left, _jump, _isonfloor;
        int _gravity = 10;
        int _force;
        int _verticalspeed = 2;
        int _horizontalspeed = 1;
        int _score;
        int _enemy1Speed = 1;
        int _enemy2Speed = 1;
        bool _enemy1Right = true;
        bool _enemy2Right = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) _right = true; 
            if (e.KeyCode == Keys.Left) _left = true;
            if (_jump != true)
            {
                if (e.KeyCode == Keys.Space) {
                    _jump = true; 
                    _force = _gravity;
                } 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) _right = false;
            if (e.KeyCode == Keys.Left) _left = false;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Platform();
            Player_movements();
            vertical_platform_movements();
            horizontal_platform_movements();
            Door();
        }

        private void Platform()
        {
            if (_jump)
            {
                player.Top -= _force;
                _force -= 1;
            }
            else player.Top += 5; 
            foreach (Control x in this.Controls) 
            { 
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "vertical_platform" || x is PictureBox && (string)x.Tag == "platform_horizon")
                {
                    Collisions(x);
                    x.BringToFront();
                }
                Coin(x);
                Clefs(x);
                Enemy_movements(x);
                Death();
            }
        }

        private void Collisions(Control x)
        {
            if (player.Bottom > x.Top && player.Bottom < x.Bottom && player.Left < x.Right && player.Right > x.Left)
            {
                player.Top = x.Top - 2 - player.Height;
                _isonfloor = true;
                _jump = false;
            }

            else if (player.Top < x.Bottom && player.Top > x.Top && player.Left < x.Right && player.Right > x.Left)
            {
                _force = 0;
                player.Top = x.Bottom;
            }

            else if (player.Right > x.Left && player.Right < x.Right && player.Top < x.Bottom && player.Bottom > x.Top)
            {
                _left = false;
            }

            else if (player.Left < x.Right && player.Left > x.Left && player.Top < x.Bottom && player.Bottom > x.Top)
            {
                _right = false;
            }
        }

        private void Player_movements()
        {
            if (_right) player.Left += 5;
            if (_left) player.Left -= 5;
        }
        
        private void vertical_platform_movements()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "vertical_platform")
                {
                    if (x.Top < pictureBox4.Bottom || x.Bottom > pictureBox3.Top)
                    {
                        _verticalspeed = -_verticalspeed;
                    }
                    x.Top += _verticalspeed;
                }
            }
        }
        private void horizontal_platform_movements()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform_horizon")
                {
                    if (x.Left < pictureBox14.Right || x.Right > pictureBox15.Left)
                    {
                        _horizontalspeed = -_horizontalspeed;
                    }
                    x.Left += _horizontalspeed;
                }
            }
        }

        private void Coin(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "coin")
            {
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    this.Controls.Remove(x);
                    _score++;
                }
                if (_score == 5)
                {
                    pictureBox11.Visible = true;
                }
                else pictureBox11.Visible = false;
            }
        }

        private void Door()
        {
            if (player.Bounds.IntersectsWith(Porte.Bounds))
            {
                timer.Stop();
                Win win = new Win();
                win.Show();
                this.Hide();
            }
        }
        private void Clefs(Control x) 
        {
            if (x is PictureBox && (string)x.Tag == "Clefs")
            {
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    this.Controls.Remove(x);
                    Porte.Image = Properties.Resources.door_open;
                }
                else
                {
                    Porte.Image = Properties.Resources.door;
                }
            }
        }
        private void Enemy_movements(Control x)
        { 
            if (x is PictureBox && (string)x.Tag == "enemy") 
            {
                Mouvement_Enemy(x);
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    timer.Stop();
                    this.Hide();
                    Menu_restart menu = new Menu_restart();
                    menu.ShowDialog();
                    this.Close();
                }
            }
            if (x is PictureBox && (string)x.Tag == "enemy2") 
            {
                Mouvement_Enemy2(x);
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    timer.Stop();
                    this.Hide();
                    Menu_restart menu = new Menu_restart();
                    menu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Mouvement_Enemy2(Control x)
        {
            x.Left += _enemy2Speed;
            if (x.Left < pictureBox27.Right || x.Right > pictureBox34.Left)
            {
                _enemy2Speed = -_enemy2Speed;
                if (_enemy2Right)
                {
                    pictureBox33.Image = Properties.Resources.enemyleft;
                    _enemy2Right = false;
                }
                else
                {
                    pictureBox33.Image = Properties.Resources.enemyright;
                    _enemy2Right = true;
                }
            }
        }

        private void Mouvement_Enemy(Control x)
        {
            x.Left += _enemy1Speed;
            if (x.Left < pictureBox25.Right || x.Right > pictureBox26.Left)
            {
                _enemy1Speed = -_enemy1Speed;
                if (_enemy1Right)
                {
                    pictureBox24.Image = Properties.Resources.enemyleft;
                    _enemy1Right = false;
                }
                else
                {
                    pictureBox24.Image = Properties.Resources.enemyright;
                    _enemy1Right = true;
                }
            }
        }
        private void Death()
        {
            if (player.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                timer.Stop();
                this.Hide();
                Menu_restart menu = new Menu_restart();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}