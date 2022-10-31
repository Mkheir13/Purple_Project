using System;
using System.Windows.Forms;

namespace Platform
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}