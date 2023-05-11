using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pz._24
{
    internal class Vector : ICloneable
    {
        private static int _countOfVec = 0;
        private static int _countOfZeroVec = 0;
        private static int _countOfLowLengthVec = 0;

        private float _x1 = 0.0f;
        private float _y1 = 0.0f;

        private float _x2 = 0.0f;
        private float _y2 = 0.0f;


        public Vector(float x, float y)
        {
            this.X2 = x;
            this.Y2 = y;
            this.StaticCount();
            this.MaxValCheck();
        }

        public Vector(float x)
        {
            this.X2 = x;
            this.StaticCount();
            this.MaxValCheck();
        }

        public Vector()
        {
            this.StaticCount();
            this.MaxValCheck();
        }

        virtual public object Clone()
        {
            return new Vector(this.X2, this.Y2);
        }


        public float X1 { get => _x1; set => _x1 = value; }
        public float Y1 { get => _y1; set => _y1 = value; }

        public float X2 { get => _x2; set => _x2 = value; }
        public float Y2 { get => _y2; set => _y2 = value; }


        private void StaticCount()
        {
            _countOfVec++;
            if (this.GetLength() < 10)
                _countOfLowLengthVec++;
            if (this.GetLength() == 0.0f)
                _countOfZeroVec++;
        }
        private void MaxValCheck()
        {
            this.X2 = this.X2 > 100 ? 100 : this.X2 < -100 ? -100 : this.X2;
            this.Y2 = this.Y2 > 100 ? 100 : this.Y2 < -100 ? -100 : this.Y2;
        }

        public void PrintInfo() => Console.WriteLine($"x = {this.X2}\ty = {this.Y2}\tCount of vectors = {_countOfVec}\tCount of zero vectors = {_countOfZeroVec}\tCount of with length < 10 = {_countOfLowLengthVec} ");

        public void Multiple(float number) => Console.WriteLine($"x * {number} = {this.X2 * number}\ty * {number} = {this.Y2 * number} ");

        virtual public void GetMiddle() => Console.WriteLine($"Сoordinates of the middle of the segment: x = {this.X2 / 2}\ty = {this.Y2 / 2} ");

        virtual public float GetLength()
        {
            return (float)(Math.Sqrt(Math.Pow((this.X2 - this.X1), 2) + Math.Pow((this.Y2 - this.Y1), 2)));
        }
    }    
}
