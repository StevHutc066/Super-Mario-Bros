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

        public Rectangle Bounds()
        {
            //Rectangle enemyRec = new Rectangle(x, y, width, height);
            //Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);
            return new Rectangle(x, y, width, height);
            //return this.Bounds();
            //if (ballRec.IntersectsWith(paddleRec) && ticksSinceHit >= 60)
            //{
            //    if (y + size >= p.y)
            //    {
            //        if ((x + size) < p.x && (y + size) > p.y)
            //        {
            //            xSpeed = -Math.Abs(xSpeed);
            //            ySpeed = Math.Abs(ySpeed);

            //        }
            //        else if (x > (p.x + p.width) && (y + size) > p.y)
            //        {
            //            xSpeed = Math.Abs(xSpeed);
            //            ySpeed = Math.Abs(ySpeed);

            //        }
            //        else
            //        {
            //            ySpeed *= -1;
            //        }
            //    }

            //    if (pMovingLeft)
            //        xSpeed = -Math.Abs(xSpeed);
            //    else if (pMovingRight)
            //        xSpeed = Math.Abs(xSpeed);
        }
    }
}
