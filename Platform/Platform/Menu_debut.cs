using System;
using System.Windows.Forms;

namespace Platform
{
    public partial class Menu_debut : Form
    {
        public Menu_debut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}