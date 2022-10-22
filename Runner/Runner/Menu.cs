using System;
using System.Windows.Forms;

namespace Runner
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.ForeColor = System.Drawing.Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
            this.Close();
        }
        
    }
}