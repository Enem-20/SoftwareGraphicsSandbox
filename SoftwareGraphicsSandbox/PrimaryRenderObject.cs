using System;
using System.Collections.Generic;
using System.Text;
using SoftwareGraphicsSandbox;

namespace UserSoftwareGraphicsSandbox{
    class PrimaryRenderObject{
        private int[] args;
        public Color32 color32 = new Color32();
        //public int x { get{ return args[0]; } set { args[0] = value; } }
        //public int y { get { return args[1]; } set { args[1] = value; } }
        public PrimaryRenderObject(int[] newArgs){
            SetArgs(newArgs);
        }
        public PrimaryRenderObject(int size = 1){
            args = new int[size];
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
        public void SetArgs(int[] newArgs) 
        { 
            if(args == null)
                args = new int[newArgs.Length];    
            newArgs.CopyTo(args, 0); 
        }
        public int this[int index] { get { return args[index]; } set { args[index] = value;} }
    }
}
