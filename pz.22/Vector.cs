using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pz._22
{
    internal class Vector
    {
        private static int _countOfVec = 0;
        private static int _countOfZeroVec = 0;
        private static int _countOfLowLengthVec = 0;

        private float _x = 0.0f;
        private float _y = 0.0f;

        public Vector(float x, float y)
        {
            _x = x;
            _y = y;
            this.StaticCount();
            this.MaxValCheck();
        }

        public Vector(float x)
        {
            _x = x;
            this.StaticCount();
            this.MaxValCheck();
        }

        public Vector()
        {
            this.StaticCount();
            this.MaxValCheck();
        }

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
            _x = _x > 100 ? 100 : _x < -100 ? -100 : _x;
            _y = _y > 100 ? 100 : _y < -100 ? -100 : _y;
        }

        public void PrintInfo() => Console.WriteLine($"x = {_x}\ty = {_y}\tCount of vectors = {_countOfVec}\tCount of zero vectors = {_countOfZeroVec}\tCount of with length < 10 = {_countOfLowLengthVec} ");

        public void Multiple(float number) => Console.WriteLine($"x * {number} = {_x * number}\ty * {number} = {_y * number} ");

        public void GetMiddle() => Console.WriteLine($"Сoordinates of the middle of the segment: x = {_x / 2}\ty = {_y / 2} ");

        public float GetLength()
        {
            return (float)(Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2)));
        }
    }    
}
