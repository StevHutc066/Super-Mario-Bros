using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Super_Mario_Bros
{
    public class Mario
    {
        public int x, y, xSpeed, ySpeed, width, height;
        public string state;
        public Image image;

        public Mario(int _x, int _y, int _xSpeed, int _ySpeed, string _state)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            state = _state;
            width = 67;
            height = 93;

            if (_state == "big")
            {
                image = Sprites.RightStand;
            }
        }


        public void Move(string dir)
        {
            if (dir == "left")
                x -= xSpeed;
            if (dir == "right")
                x += xSpeed;
        }

        public void Fall()
        {
            y += ySpeed;
        }

        public bool InAirCollision(Mario mario)
        {
            return false;
        }

        public Rectangle Bounds()
        {
            Rectangle rect = new Rectangle(x, y, width, height); 
            return rect;
        }

        public bool HeroCollision(Enemy e)
        {
            Rectangle heroRec = new Rectangle(x, y, width, height);
            Rectangle enemyRec = new Rectangle(e.x, e.y, e.width, e.height);

            return heroRec.IntersectsWith(enemyRec);
        }
    }
}
