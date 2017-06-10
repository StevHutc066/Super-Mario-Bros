using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Mario_Bros
{
    class Mario
    {
        public int x, y, xSpeed, ySpeed, width, height;
        string state;


        public Mario(int _x, int _y, int _xSpeed, int _ySpeed, string _state)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            state = _state;
            width = 8;
            height = 117;
        }


        public void Move(string dir)
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }
    }
}
