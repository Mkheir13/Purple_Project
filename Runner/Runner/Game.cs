using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Runner
{
    public partial class Game : Form
    {
        //player variables
        bool _moveLeft;
        bool _moveright;
        bool _jumping;
        //players speed variables
        int _jumpSpeed = 12;
        int _force = 10;
        int _score; 
        int _gumbaspeed = -1;
        int _gumbaspeed2 = -1;
        int verticalSpeed = 3;
        int horizontalSpeed = 3;
        int horizontalSpeed2 = 3;
        int _index = 0;
        bool _gumbaleft = true;
        bool _gumbaleft2 = true;


        public Game()
        {
            InitializeComponent();
        }


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _moveLeft = true;
                    break;
                case Keys.Right:
                    _moveright = true;
                    break;
                case Keys.Space:
                    _jumping = true;
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _moveLeft = false;
                    break;
                case Keys.Right:
                    _moveright = false;
                    break;
                case Keys.Space:
                    _jumping = false;
                    break;
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            finn.Top += _jumpSpeed;
            scoreText.Text = @"Score: " + _score;
            _index++;

            if (_jumping && _force < 0) _jumping = false;
            
            if (_moveLeft)
            {
                if (_index % 5 == 0)
                {
                    //finn.Image = Properties.Resources.finn_run_left;
                }
                finn.Left -= 5;
                //finn.Image = Properties.Resources.finn_run_left;
            }

            if (_moveright)
            {
                if (_index % 5  == 0)
                {
                    //finn.Image = Properties.Resources.finn_run_right;
                }
                finn.Left += 5;
                //finn.Image = Properties.Resources.finn_run_right;
            }

            if (_jumping)
            {
                _jumpSpeed = -12;
                _force -= 1;
            }
            else _jumpSpeed = 12;
            
            Dead();
            vertical_platform();
            horizontal_platform();
            Plateform();
            Door();
        }

        private void Dead()
        {
            if (finn.Top > pictureBox18.Bottom)
            {
                timer1.Stop();
                MessageBox.Show(@"Game Over");
                Application.Exit();
            }
        }

        private void vertical_platform()
        {
            verticalplatform.Top -= verticalSpeed;
            if (verticalplatform.Bottom > pictureBox10.Top || verticalplatform.Top < pictureBox11.Bottom)
            {
                verticalSpeed = -verticalSpeed;
            }
        }

        private void horizontal_platform()
        {
            horizontalplatformone.Left -= horizontalSpeed;
            if (horizontalplatformone.Right > pictureBox10.Left || horizontalplatformone.Left < pictureBox8.Right)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            horizontalplatformtwo.Left -= horizontalSpeed2;
            if (horizontalplatformtwo.Right > pictureBox17.Left || horizontalplatformtwo.Left < pictureBox19.Right)
            {
                horizontalSpeed2 = -horizontalSpeed2;
            }
        }

        private void Plateform()
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform")
                    {
                        Collision(x);
                        x.BringToFront();
                    }
                    GumbaTwo(x);
                    Gumba(x);
                    Coin(x);
                    Clefs(x);
                }
            }

            private void Collision(Control x)
            {
                if (finn.Bounds.IntersectsWith(x.Bounds))
                {
                    if (finn.Bottom > x.Top && finn.Bottom < x.Bottom)
                    {
                        _force = 8;
                        finn.Top = x.Top + 2 - finn.Height;
                    }
                    else if (finn.Top < x.Bottom && finn.Top > x.Top)
                    {
                        finn.Top = x.Bottom;
                    }
                    else if (finn.Right > x.Left && finn.Left < x.Left)
                    {
                        _force = 0;
                        finn.Left = x.Left - finn.Width;
                    }
                    else if (finn.Left < x.Right && finn.Right > x.Right)
                    {
                        _force = 0;
                        finn.Left = x.Right;
                    }
                }
            }

            private void Door()
        {
            if (finn.Bounds.IntersectsWith(door.Bounds) && _score >= 7)
            {
                timer1.Stop();
                MessageBox.Show("You Win!");
                Close();
            }
            BringToFront();
        }
            
        //close app when form is closed 

        private void Coin(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "coin")
            {
                if (finn.Bounds.IntersectsWith(x.Bounds) && !_jumping)
                {
                    this.Controls.Remove(x);
                    _score++;
                }
                if (_score == 6)
                {
                    picture_key.Visible = true;
                }
                else picture_key.Visible = false;
            }
        }

        private void Clefs(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "key")
            {
                if (finn.Bounds.IntersectsWith(x.Bounds) && !_jumping)
                {
                    this.Controls.Remove(x);
                    door.Visible = true;
                }
                else door.Visible = false;
            }
        }

        private void Gumba(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "gumba")
            {
                Movement(x);
                if (finn.Bounds.IntersectsWith(x.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show(@"Game Over");
                    Application.Exit();
                }
            }
        }

        private void GumbaTwo(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "gumbatwo")
            {
                MovementTwo(x);
                if (finn.Bounds.IntersectsWith(x.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show(@"Game Over");
                    Application.Exit();
                }
            }
        }

        void Movement(Control x)
        {
            x.Left += _gumbaspeed;
            if (x.Left < pictureBox27.Right || x.Left + x.Width > pictureBox19.Left)
            {
                _gumbaspeed = -_gumbaspeed;
                if (_gumbaleft)
                {
                    pictureBox26.Image = Properties.Resources.enemyright;
                    _gumbaleft = false;
                }
                else
                {
                    pictureBox26.Image = Properties.Resources.enemyleft;
                    _gumbaleft = true;
                }
            }
        }
        void MovementTwo(Control x)
        {
            x.Left += _gumbaspeed2;
            if (x.Left < 0 || x.Left + x.Width > pictureBox8.Left)
            {
                _gumbaspeed2 = -_gumbaspeed2;
                if (_gumbaleft2)
                {
                    pictureBox16.Image = Properties.Resources.enemyright;
                    _gumbaleft2 = false;
                }
                else
                {
                    pictureBox16.Image = Properties.Resources.enemyleft;
                    _gumbaleft2 = true;
                }
            }
        }
    }
}