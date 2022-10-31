using System;
using System.Timers;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _ballspeed = 5;
        bool _goUp;
        bool _goDown;
        int _ballX = 5;
        int _ballY = 5;
        int _score;
        int _playertwoScore;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _goUp = true;
            if (e.KeyCode == Keys.Down) _goDown = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _goUp = false;
            if (e.KeyCode == Keys.Down) _goDown = false;
        }

        private void Timer(object sender, ElapsedEventArgs e)
        {
            PlayerScore.Text = "" + _score;
            CpuScore.Text = "" + _playertwoScore;
            Player_movement();
            Ball_movement();
            Player_Collision();
            Win();
        }

        private void Player_movement()
        {
            if (_goUp && playerone.Top > this.panel1.Top) playerone.Top -= 8;
            if (_goDown && playerone.Bottom < this.panel1.Bottom - playerone.Width) playerone.Top += 8;
        }
        private void Ball_movement()
        {
            ball.Left += _ballX;
            ball.Top += _ballY;
            if (ball.Bottom >= panel1.Bottom || ball.Top <= panel1.Top) _ballY = -_ballY;
            if (ball.Left <= panel1.Left)
            {
                ball.Left = panel1.Width / 2;
                ball.Top = panel1.Height / 2;
                _ballX = -_ballX;
                _ballY = -_ballY;
                _playertwoScore++;
            }
            if (ball.Right >= panel1.Right)
            {
                ball.Left = panel1.Width / 2;
                ball.Top = panel1.Height / 2;
                _ballX = -_ballX;
                _ballY = -_ballY;
                _score++;
            }
        }
        private void Player_Collision()
        {
            if (ball.Bounds.IntersectsWith(playerone.Bounds))
            {
                if (ball.Left < playerone.Right - 20) _ballY = -_ballY;
                else _ballX = -_ballX;
                if (ball.Bottom > playerone.Top && ball.Top < playerone.Bottom) _ballY = -_ballY;
                else _ballX = -_ballX;
                if (ball.Left < playerone.Left)
                {
                    ball.Left = panel1.Width / 2;
                    ball.Top = panel1.Height / 2;
                    _ballX = -_ballX;
                    _ballY = -_ballY;
                }
            }
        }
        private void Win()
        {
            if (_score == 2)
            {
                MessageBox.Show("Player One Wins!");
                _score = 0;
                _playertwoScore = 0;
                
            }
            if (_playertwoScore == 10)
            {
                MessageBox.Show("Player Two Wins!");
                _score = 0;
                _playertwoScore = 0;
            }
        }
        
    }
}