using System;
using System.Collections.Generic;
using System.Text;

namespace UserSoftwareGraphicsSandbox{
    class PrimaryRenderObject{
        private int[] args;
        int x { get{ return args[0]; } set { args[0] = value; } }
        int y { get { return args[1]; } set { args[1] = value; } }
        public PrimaryRenderObject(int[] newArgs){
            SetArgs(newArgs);
        }
        public PrimaryRenderObject(int x = 0, int y = 0, int size = 1){
            args = new int[size];
            this.x = x;
            this.y = y;
        }
        public PrimaryRenderObject GetCopy(){
            PrimaryRenderObject renderObject = new PrimaryRenderObject();
            args.CopyTo(renderObject.args, 0);
            return renderObject;
        }
        //public PrimaryRenderObject NormalizeInRange(int OldMin, int OldMax, int min, int max){
        //    PrimaryRenderObject renderObject = new PrimaryRenderObject();
        //    int[] points = new int[args.Length];
        //    for (int i = 0; i < args.Length; i++)
        //    {
        //        points[i] = (max - min) * (this[i] - OldMin) / (OldMax - OldMin);
        //    }
        //    renderObject.SetArgs(points);
        //    return renderObject;
        //}
        public void SetArgs(int[] newArgs) { newArgs.CopyTo(args, 0); }
        public int this[int index] { get { return args[index]; } set { args[index] = value;} }
    }
}
