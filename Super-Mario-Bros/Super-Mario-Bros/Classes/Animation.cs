using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Super_Mario_Bros
{
    class Animation
    {
        Bitmap[] images;

        int index = 0;

        public Animation(Bitmap[] _images)
        {
            images = _images;
        }

        public Bitmap GetNextImage()
        {
            Bitmap b = null;

            if (index < images.Length)
            {
                b = images[index++];
            }
            else
            {
                index = 0;
                b = images[index++];
            }

            return b;
        }
    }
}
