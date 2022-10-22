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
        int _gumbaspeed = -3;


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

            if (_jumping && _force < 0) _jumping = false;

            if (_moveLeft) finn.Left -= 5;

            if (_moveright) finn.Left += 5;

            if (_jumping)
            {
                _jumpSpeed = -12;
                _force -= 1;
            }
            else _jumpSpeed = 12;

            Plateform();
            Door();
        }

            private void Plateform()
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform")
                    {
                        if (finn.Bottom > x.Top && finn.Bottom < x.Bottom && finn.Left > x.Left && finn.Right < x.Right)
                        {
                            _force = 8;
                            finn.Top = x.Top - finn.Height;
                        }
                        if (finn.Top < x.Bottom && finn.Top > x.Top && finn.Left > x.Left && finn.Right < x.Right)
                        {
                            finn.Top = x.Bottom;
                        }
                        if (finn.Right > x.Left && finn.Right < x.Right && finn.Top < x.Bottom && finn.Bottom > x.Top)
                        {
                            finn.Left = x.Left - finn.Width;
                        }
                        if (finn.Left < x.Right && finn.Left > x.Left && finn.Top < x.Bottom && finn.Bottom > x.Top)
                        {
                            finn.Left = x.Right;
                        }
                        x.BringToFront();
                    }

                    Coin(x);
                    //Gumba(x);
                }
            }

        private void Door()
        {
            if (finn.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                MessageBox.Show(@"You WIN");
            }
        }

        private void Coin(Control x)
        {
            if (x is PictureBox && (string)x.Tag == "coin")
            {
                if (finn.Bounds.IntersectsWith(x.Bounds) && !_jumping)
                {
                    this.Controls.Remove(x);
                    _score++;
                }
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
                }
            }
        }
        void Movement(Control x)
        {
            x.Left += _gumbaspeed;
            if (x.Left < 0 || x.Left + x.Width > this.ClientSize.Width)
            {
                _gumbaspeed = -_gumbaspeed;
            }
        }
        
    }
}