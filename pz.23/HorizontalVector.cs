using System;
using System.Collections.Generic;
using System.Text;

namespace pz._23
{
    internal class HorizontalVector : Vector 
    {
        public HorizontalVector(float x, float y) : base(x, y)
        {
            base.Y1 = y;
        }

        public HorizontalVector(float x) : base(x)
        { 

        }

        public HorizontalVector() : base()
        { 

        }

        override public void GetMiddle() => Console.WriteLine($"Сoordinates of the middle of the segment: x = {this.X2 / 2}\ty = {this.Y2} ");

        override public float GetLength()
        {
            return (float)(base.X2 - base.X1);
        }
    }
}
