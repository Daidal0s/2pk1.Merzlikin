namespace pz._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float num = 2.5f;

            Vector vec1 = new();
            vec1.PrintInfo();
            vec1.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec1.GetLength());
            vec1.GetMiddle();
            Console.WriteLine();

            Vector vec2 = new(120, 3);
            vec2.PrintInfo();
            vec2.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec2.GetLength());
            vec2.GetMiddle();
            Console.WriteLine();

            Vector vec3 = new(12);
            vec3.PrintInfo();
            vec3.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec3.GetLength());
            vec3.GetMiddle();
            Console.WriteLine();

            int a = 0;
        }
    }
}