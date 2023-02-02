namespace pz._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new();
            Vector vec2 = new(2, 3);
            Vector vec3 = new(3);

            const float num = 2.5f;

            vec1.PrintInfo();
            vec1.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec1.GetLength());
            vec1.GetMiddle();
            Console.WriteLine();

            vec2.PrintInfo();
            vec2.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec2.GetLength());
            vec2.GetMiddle();
            Console.WriteLine();

            vec3.PrintInfo();
            vec3.Multiple(num);
            Console.WriteLine("Length of the vector = " + vec3.GetLength());
            vec3.GetMiddle();
            Console.WriteLine();
        }
    }
}