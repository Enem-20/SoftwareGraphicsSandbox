using System;
using System.Collections.Generic;
using System.Text;

namespace UserSoftwareGraphicsSandbox{
    class AnyPoint : PrimaryRenderObject{
        public AnyPoint(int x, int y) : base(new int[2] {x, y}) { }
        public AnyPoint(int[] args) : base(args) { }
    }
}
