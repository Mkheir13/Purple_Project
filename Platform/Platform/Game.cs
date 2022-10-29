
using System.Timers;
using System.Windows.Forms;

namespace Platform
{
    public partial class Form1 : Form
    {
        bool _right, _left, _jump;
        int _gravity = 10;
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
            if (_right) player.Left += 5;
            if (_left) player.Left -= 5;
            if (_jump)
            {
                player.Top -= _force;
                _force -= 1;
            }
            if (player.Top + player.Height >= this.ClientSize.Height) _jump = false;
            else player.Top += 5;
        }
    }
}