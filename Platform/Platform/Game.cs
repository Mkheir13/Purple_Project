
using System;
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
            Collisions();
            Player_movements();
            vertical_platform_movements();
            horizontal_platform_movements();
        }

        private void Collisions()
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
    }
}