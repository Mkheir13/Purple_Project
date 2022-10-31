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
        bool _goUp;
        bool _goDown;
        bool _goZ;
        bool _goS;
        int _ballX = 10;
        int _ballY = 10;
        int _score;
        int _playertwoScore;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _goUp = true;
            if (e.KeyCode == Keys.Down) _goDown = true;
            if (e.KeyCode == Keys.Z) _goZ = true;
            if (e.KeyCode == Keys.S) _goS = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _goUp = false;
            if (e.KeyCode == Keys.Down) _goDown = false;
            if (e.KeyCode == Keys.Z) _goZ = false;
            if (e.KeyCode == Keys.S) _goS = false;
        }

        private void Timer(object sender, ElapsedEventArgs e)
        {
            //increase ball speed with the score

            PlayerScore.Text = "" + _score;
            CpuScore.Text = "" + _playertwoScore;
            Player_movement();
            Cpumovement();
            Ball_movement();
            Player_Collision();
            Cpu_Collision();
            Win();
        }

        private void Player_movement()
        {
            if (_goUp && playertwo.Top > this.panel1.Top) playertwo.Top -= 8;
            if (_goDown && playertwo.Bottom < this.panel1.Bottom - playertwo.Width) playertwo.Top += 8;
        }
        private void Cpumovement()
        {
            if (_goZ && playerone.Top > this.panel1.Top) playerone.Top -= 8;
            if ( _goS && playerone.Bottom < this.panel1.Bottom - playerone.Width) playerone.Top += 8;
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
        private void Cpu_Collision()
        {
            if (ball.Bounds.IntersectsWith(playertwo.Bounds))
            {
                if (ball.Right < playertwo.Left) _ballY = -_ballY;
                else _ballX = -_ballX;
                if (ball.Bottom > playertwo.Top && ball.Top < playertwo.Bottom) _ballY = -_ballY;
                else _ballX = -_ballX;
                if (ball.Right > playertwo.Right + 40)
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
            if (_score == 10)
            {
                timer1.Stop();
                MessageBox.Show(@"Player One Wins!");
                _score = 0;
                _playertwoScore = 0;

            }
            if (_playertwoScore == 10)
            {
                timer1.Stop();
                MessageBox.Show(@"Player Two Wins!");
                _score = 0;
                _playertwoScore = 0;
            }
        }
        
    }
}