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
        int x, y, size, speed, direction;

        Image[] images = new Image[4];

        public Bullet(int _x, int _y, int _size, int _speed, int _direction, Image[] _images)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
            images = _images;
        }

        public void move(Bullet b)
        {
            //TODO
        }
    }
}
