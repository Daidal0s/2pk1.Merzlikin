using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz._21
{
    internal class Vector
    {
        private float _x = 0.0f;
        private float _y = 0.0f;

        public Vector(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public Vector(float x)
        {
            _x = x;
        }

        public Vector()
        {

        }

        public void PrintInfo() => Console.WriteLine($"x = {_x}\ty = {_y} ");

        public void Multiple(float number) => Console.WriteLine($"x * {number} = {_x * number}\ty * {number} = {_y * number} ");

        public void GetMiddle() => Console.WriteLine($"Сoordinates of the middle of the segment: x = {_x / 2}\ty = {_y / 2} ");

        public float GetLength()
        {
            return (float)(Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2)));
        }
    }
}
