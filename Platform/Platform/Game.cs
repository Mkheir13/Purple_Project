
using System.Timers;
using System.Windows.Forms;

namespace Platform
{
    public partial class Form1 : Form
    {
        bool _right, _left, _jump;
        int _gravity = 15;
        int _force;
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
            foreach (Control x in this.Controls)
            { 
                if (x is PictureBox && (string)x.Tag == "platform")
                { 
                    if (player.Bottom > x.Top && player.Bottom < x.Bottom && player.Left < x.Right && player.Right > x.Left)
                    {
                        _jump = false;
                        _force = _gravity;
                        player.Top = x.Top - player.Height;
                    } 
                    if (player.Top < x.Bottom && player.Top > x.Top && player.Left < x.Right && player.Right > x.Left)
                    {
                        _force = 0;
                        player.Top = x.Bottom;
                    } 
                    if (player.Right > x.Left && player.Right < x.Right && player.Top < x.Bottom && player.Bottom > x.Top)
                    {
                        player.Left = x.Left - player.Width;
                    } 
                    if (player.Left < x.Right && player.Left > x.Left && player.Top < x.Bottom && player.Bottom > x.Top) 
                    {
                        player.Left = x.Right;
                    }
                }
            }
            Player_movements();
        }

        private void Player_movements()
        {
            if (_right) player.Left += 5;
            if (_left) player.Left -= 5;
            if (_jump)
            {
                player.Top -= _force;
                _force -= 1;
            }

            if (player.Top + player.Height >= this.ClientSize.Height)
            {
                player.Top = this.ClientSize.Height - player.Height;
                _jump = false;
            }
            else player.Top += 5;
        }
    }
}