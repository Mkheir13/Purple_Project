using System;
using System.Windows.Forms;

namespace Platform
{
    public partial class Menu_restart : Form
    {
        public Menu_restart()
        {
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}