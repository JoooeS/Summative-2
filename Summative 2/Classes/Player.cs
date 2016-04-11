using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Summative_2
{
    class Player
    {
        public int x, y, size, speed;

        public string direction;

        public Image[] up = new Image[4];
        public Image[] down = new Image[4];
        public Image[] left = new Image[4];
        public Image[] right = new Image[4];
        

        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="_x">X Location</param>
        /// <param name="_y">Y Location</param>
        /// <param name="_size">Size of the player</param>
        /// <param name="_speed">Speed of the player</param>
        /// <param name="_direction">Direction of the player</param>
        /// <param name="_up">Image array to move up</param>
        /// <param name="_down">Image array to move down</param>
        /// <param name="_left">Image array to move left</param>
        /// <param name="_right">Image arrray to move right</param>
        public Player (int _x, int _y, int _size, int _speed, string _direction, Image[] _up, Image[] _down, Image[] _left, Image[] _right)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
            down = _down;
            up = _up;
            left = _left;
            right = _right;
        }

        /// <summary>
        /// Move method
        /// </summary>
        /// <param name="p">Player</param>
        /// <param name="direction">Direction of player</param>
        public void move(Player p, string direction)
        {
            if (direction == "left")
            {
                if (p.x > 0)
                {
                    p.x -= p.speed;
                }
            }
            else if (direction == "right")
            {
                if (p.x < 570)
                {
                    p.x += p.speed;
                }
            }
            else if (direction == "down")
            {
                if (p.y < 370)
                {
                    p.y += p.speed;
                }
            }
            else if (direction == "up")
            {
                if (p.y > 290)
                {
                    p.y -= p.speed;
                }
            }
        }

        /// <summary>
        /// Collision check
        /// </summary>
        /// <param name="p">Player</param>
        /// <param name="m">Monster</param>
        /// <returns></returns>
        public bool collision(Player p, Monster m)
        {
            Rectangle pRc = new Rectangle(p.x, p.y, p.size, p.size);
            Rectangle mRc = new Rectangle(m.x, m.y, m.size, m.size);

            if (pRc.IntersectsWith(mRc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
