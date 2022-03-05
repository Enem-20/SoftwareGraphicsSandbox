using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserSoftwareGraphicsSandbox{
    class AnyLine : PrimaryRenderObject{
        public AnyLine(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 0) : base(new int[4] {x1, y1, x2, y2}){}
        public AnyLine(int[] points){
            SetArgs(points);
        }

    }
}
