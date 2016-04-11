using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Summative_2
{
    class Monster
    {
        public int x, y, size, speed;
        public string direction;
        public Image mons;

        /// <summary>
        /// Constructor method for creating a bullet
        /// </summary>
        /// <param name="_x">starting x point</param>
        /// <param name="_y">starting y point</param>
        /// <param name="_size">size of the bullet</param>
        /// <param name="_speed">speed of the bullet</param>
        /// <param name="_direction">direction: left or right</param>
        /// <param name="_mons">One image</param>
        public Monster(int _x, int _y, int _size, int _speed, string _direction, Image _mons)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
            mons = _mons;
        }
        
        /// <summary>
        /// Move method
        /// </summary>
        /// <param name="m">The specified monster</param>
        /// <param name="direction">The direction</param>
        public void move(Monster m, string direction)
        {
            if (direction == "left")
            {
                m.x -= m.speed;
            }
        }
    }
}
