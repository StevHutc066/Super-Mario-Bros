using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Super_Mario_Bros
{
    public class Enemy
    {
        public int x, y, width, height, xSpeed, ySpeed;
        public Image image;
        public Enemy(int _x, int _y, int _width, int _height, int _xSpeed, int _ySpeed, Image _image)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            image = _image;
            width = _width;
            height = _height;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= xSpeed;
            }
            if (direction == "right")
            {
                x += xSpeed;
            }
        }
    }
}
