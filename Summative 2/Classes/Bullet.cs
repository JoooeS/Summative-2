using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Summative_2
{
    class Bullet
    {
        public int x, y, size, speed;
        public string direction;
        public Image[] images = new Image[2];

        /// <summary>
        /// Constructor method for creating a bullet
        /// </summary>
        /// <param name="_x">Starting x-point of the bullet</param>
        /// <param name="_y">Starting y-point of the bullet</param>
        /// <param name="_size">Size of the bullet</param>
        /// <param name="_speed">Speed of the bullet</param>
        /// <param name="_direction">Direction of the bullet: left or right</param>
        /// <param name="_images">Iamge arrray of two pictures for the two different directions</param>
        public Bullet(int _x, int _y, int _size, int _speed, string _direction, Image[] _images)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
            images = _images;
        }

        /// <summary>
        /// Movement of bullet
        /// </summary>
        /// <param name="b">Bullet</param>
        public void move(Bullet b)
        {
            if (b.direction == "left")
            {
                b.x -= b.speed;
            }
            else if (b.direction == "right")
            {
                b.x += b.speed;
            }
        }

        /// <summary>
        /// Collision check
        /// </summary>
        /// <param name="b">Bullet</param>
        /// <param name="m">Monster</param>
        /// <returns></returns>
        public bool collision(Bullet b, Monster m)
        {
            Rectangle bRc = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle mRc = new Rectangle(m.x, m.y, m.size, m.size);

            if (bRc.IntersectsWith(mRc))
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
