using System.Data.Common;
using System.Numerics;

namespace overloading.ops
{
    internal class Program
    {
        class Vector
        {
            private static double _x1Cord = 0.0d;
            private static double _y1Cord = 0.0d;

            private static double _x2Cord = 0.0d;
            private static double _y2Cord = 0.0d;

            private static bool _isPositive = true;

            private static double _length = 0.0d;

            public Vector(double x1, double y1, double x2, double y2) 
            { 
                _x1Cord = x1;
                _y1Cord = y1;
                _x2Cord = x2;
                _y2Cord = y2;
                findLength();
                checkOnPos();
            }

            public Vector(double x1, double y1) : this(x1, y1, 0, 0) { }

            public Vector() : this(0, 0, 0, 0) { }

            public static Vector operator *(Vector v1, int t) { return new Vector(_x1Cord * t, _y1Cord * t, _x2Cord * t, _y2Cord * t); }

            public override string ToString()
            {
                string nap = _isPositive == true ? "Положительное" : "Отрицательно" ;
                return new string($"Координаты первой точки = {_x1Cord} {_y1Cord}\tКоординаты второй точки = {_x2Cord} {_y2Cord}\tДлина = {_length}\tНаправление = {nap}");
            }

            private static void findLength()
            {
                _length = Math.Sqrt(Math.Pow(_x2Cord - _x1Cord, 2) + Math.Pow(_y2Cord - _y1Cord, 2));
            }

            private static void checkOnPos()
            {
                if (_x2Cord < _x1Cord)
                    _isPositive = false;
                else
                    _isPositive = true;
            }
        }

        static void Main(string[] args)
        {
            Vector vec = new Vector(1, 4, -2, 6);
            
            Console.WriteLine(vec.ToString());
            Console.WriteLine((vec*2).ToString());

        }
    }
}