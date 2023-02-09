using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pz._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float num = 2.5f;

            Vector vec1 = new Vector();
            vec1.PrintInfo();
            vec1.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec1.GetLength());
            vec1.GetMiddle();
            Console.WriteLine();

            Vector vec2 = new Vector(120, 3);
            vec2.PrintInfo();
            vec2.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec2.GetLength());
            vec2.GetMiddle();
            Console.WriteLine();

            Vector vec3 = new Vector(12);
            vec3.PrintInfo();
            vec3.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec3.GetLength());
            vec3.GetMiddle();
            Console.WriteLine();

            HorizontalVector hv1 = new HorizontalVector();
            hv1.PrintInfo();
            hv1.Multiple(num);
            Console.WriteLine("Length of the horizontal vector = " + hv1.GetLength());
            hv1.GetMiddle();
            Console.WriteLine();

            HorizontalVector hv2 = new HorizontalVector(120, -100);
            hv2.PrintInfo();
            hv2.Multiple(num);
            Console.WriteLine("Length of the horizontal vector = " + hv2.GetLength());
            hv2.GetMiddle();
            Console.WriteLine();
            
            HorizontalVector hv3 = new HorizontalVector(12);
            hv3.PrintInfo();
            hv3.Multiple(num);
            Console.WriteLine("Length of the horizontal vector = " + hv3.GetLength());
            hv3.GetMiddle();
            Console.WriteLine();
        }
    }
}