using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SoftwareGraphicsSandbox;

namespace UserSoftwareGraphicsSandbox{
    class AnyLine : PrimaryRenderObject {
        public AnyLine(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 0) : base(new int[4] { x1, y1, x2, y2 }) { }
        public AnyLine(int[] points) {
            SetArgs(points);
        }

        public void SetPixels(Image image)
        {
            int dx = this[2] - this[0]; //x2 - x1
            int dy = this[3] - this[1]; //y2 - y1
            int y = this[1]; //y1
            int eps = 0;

            for (int x = this[0]; x <= this[2]; x++)
            {
                image.SetPixel(x, y, color32);

                eps += dy;
                if ((eps << 1) >= dx)
                {
                    y++; eps -= dx;
                }
            }

            //for (int x = 0; x < 100; ++x)
            //{
            //    image.SetPixel(x + 100, 100, color32);
            //}
        }
    }
}
