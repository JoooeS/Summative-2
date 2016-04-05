using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Summative_2
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();

            buttonStart.BackColor = Color.FromArgb(100, 108, 50, 80);
            buttonEnd.BackColor = Color.FromArgb(100, 50, 50, 120);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
