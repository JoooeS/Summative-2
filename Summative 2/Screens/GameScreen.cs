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
        #region Variables
        public static int score;
        int scoreCounter;
        int frame = 0;

        List<Monster> monsters = new List<Monster>();
        List<Bullet> bullets = new List<Bullet>();

        Random randPos = new Random();
        Boolean keyDown, spaceKeyDown;
        Player p;

        Image[] bImages = new Image[2];
        #endregion

        public GameScreen()
        {
            InitializeComponent();

            timerGame.Enabled = true;
            timerGame.Start();

            Image[] pUp = new Image[4];
            pUp[0] = Properties.Resources.up1;
            pUp[1] = Properties.Resources.up2;
            pUp[2] = Properties.Resources.up3;
            pUp[3] = Properties.Resources.up4;

            Image[] pDown = new Image[4];
            pDown[0] = Properties.Resources.down1;
            pDown[1] = Properties.Resources.down2;
            pDown[2] = Properties.Resources.down3;
            pDown[3] = Properties.Resources.down4;

            Image[] pLeft = new Image[4];
            pLeft[0] = Properties.Resources.left1;
            pLeft[1] = Properties.Resources.left2;
            pLeft[2] = Properties.Resources.left3;
            pLeft[3] = Properties.Resources.left4;

            Image[] pRight = new Image[4];
            pRight[0] = Properties.Resources.right2;
            pRight[1] = Properties.Resources.right1;
            pRight[2] = Properties.Resources.right3;
            pRight[3] = Properties.Resources.right4;

            
            bImages[0] = Properties.Resources._4;
            bImages[1] = Properties.Resources._5;

            p = new Player(300, 280, 30, 4, "right", pUp, pDown, pLeft, pRight);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            #region Score and frame
            scoreCounter++;

            // Once frame is 3, reset back to 0
            if (frame == 3)
            {
                frame = 0;
            }

            // To slow down the score increase to something appropriate
            if (scoreCounter % 4 == 0)
            {
                score++;

                // Move the monster slowly
                foreach (Monster m in monsters)
                {
                    m.move(m, m.direction);
                }
            }

            // Display score
            labelScore.Text = "Courage: " + Convert.ToString(score);
            labelScore.Refresh();
            #endregion

            #region Button Press Check

            // Monitor the movement of the player
            if (keyDown == true)
            {
                p.move(p, p.direction);

                if (scoreCounter % 2 == 0)
                {
                    frame++;
                }
            }

            //Monitor the shooting button : space key
            if (spaceKeyDown == true)
            {
                Bullet b;
                if (p.direction == "right")
                {
                    b = new Bullet(p.x, p.y, 4, 8, "right", bImages);
                    bullets.Add(b);
                }
                else if (p.direction == "left")
                {
                    b = new Bullet(p.x, p.y, 4, 8, "left", bImages);
                    bullets.Add(b);
                }
                
            }
            #endregion

            #region Collision checks

            // Ocasionally create a new monster
            if (scoreCounter % 64 == 0)
            {
                Monster m = new Monster(600, randPos.Next(280, 371), 30, 4, "left", Properties.Resources.mons);
                monsters.Add(m);
            }

            // Check for player and monster collision
            foreach (Monster m in monsters)
            {
                if (p.collision(p, m) == true)
                {
                    timerGame.Enabled = false;

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOverScreen gos = new GameOverScreen();
                    f.Controls.Add(gos);
                    break;
                }
            }

            //Movement of bullets
            foreach (Bullet b in bullets)
            {
                b.move(b);
            }

            int monsterIndex = -1;
            bool collision = false;

            // Check for bullet and monster collision
            foreach (Monster m in monsters)
            {
                foreach (Bullet b in bullets)
                {
                    if (b.collision(b, m) == true)
                    {
                        collision = true;
                        bullets.Remove(b);
                        monsterIndex = monsters.IndexOf(m);
                        break;
                    }
                }
                if (collision == true)
                {
                    monsters.RemoveAt(monsterIndex);             // HERE!
                    //bullets.RemoveAt(bulletIndex);
                    collision = false;
                    break;
                }
            }
            #endregion

            Refresh();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    keyDown = true;
                    p.direction = "left";
                    break;
                case Keys.Down:
                    keyDown = true;
                    p.direction = "down";
                    break;
                case Keys.Right:
                    keyDown = true;
                    p.direction = "right";
                    break;
                case Keys.Up:
                    keyDown = true;
                    p.direction = "up";
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    keyDown = false;
                    frame = 0;
                    break;
                case Keys.Down:
                    keyDown = false;
                    frame = 0;
                    break;
                case Keys.Right:
                    keyDown = false;
                    frame = 0;
                    break;
                case Keys.Up:
                    keyDown = false;
                    frame = 0;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    frame = 0;
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            string i = p.direction;
            if (p.direction == "right")
            {
                e.Graphics.DrawImage(p.right[frame], p.x, p.y, p.size, p.size);
            }
            else if (p.direction == "left")
            {
                e.Graphics.DrawImage(p.left[frame], p.x, p.y, p.size, p.size);
            }
            else if (p.direction == "down")
            {
                e.Graphics.DrawImage(p.down[frame], p.x, p.y, p.size, p.size);
            }
            else if (p.direction == "up")
            {
                e.Graphics.DrawImage(p.up[frame], p.x, p.y, p.size, p.size);
            }

            foreach (Monster m in monsters)
            {
                e.Graphics.DrawImage(m.mons, m.x, m.y, m.size, m.size);
            }
            foreach (Bullet b in bullets)
            {
                if (b.direction == "left")
                {
                    e.Graphics.DrawImage(b.images[0], b.x, b.y, b.size, b.size);
                }
                else if (b.direction == "right")
                {
                    e.Graphics.DrawImage(b.images[1], b.x, b.y, b.size, b.size);
                }
            }
        }
    }
}
