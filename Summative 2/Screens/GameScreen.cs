using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_2
{
    public partial class GameScreen : UserControl
    {
        public static int score;

        int scoreCounter;

        public GameScreen()
        {
            InitializeComponent();

            timerGame.Enabled = true;
            timerGame.Start();


        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            #region Increasing score by counter by time
            scoreCounter++;

            // To slow down score increase
            if (scoreCounter == 4)
            {
                score++;
                scoreCounter = 0;
            }

            // Display score
            labelScore.Text = "Score: " + Convert.ToString(score);
            labelScore.Refresh();
            #endregion


        }
    }
}
