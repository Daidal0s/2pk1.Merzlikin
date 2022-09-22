namespace pz._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗадание 1");
            for(byte i = 10; i <= 80; i+=4)
                Console.WriteLine(i);

            Console.WriteLine("\tЗадание 2");
            for(char i = 'В'; i != 'В' + 7; i++)
                Console.Write(i);

            Console.WriteLine("\n\tЗадание 3");
            for(byte i = 0; i < 7; i++)
            {
                for(byte c = 0; c < 7; c++)
                    Console.Write('#');
                Console.Write('\n');
            }

            Console.WriteLine("\tЗадание 4");
            for (sbyte i = 0; i <= 100; i++)
                if (i % 17 == 0)
                    Console.WriteLine(i);

            Console.WriteLine("\tЗадание 5");
            byte j = 70;
            for (byte i = 5; j - i >= 19; i++)
            {
                Console.WriteLine($"i = {i}\tj = {j}\tРазница = {j-i}");
                --j;
            }
        }
    }
}