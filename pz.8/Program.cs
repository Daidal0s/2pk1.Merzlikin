namespace pz._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Введите значение столбцов M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение строчек N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char[,] c_arr = new char[m,n];
            short[] s_arr = new short[26];
            
            Console.WriteLine();

            for (int i = 0; i <= c_arr.GetUpperBound(0); i++)                                   // Заполнение двумерного массива
                for (int j = 0; j <= c_arr.GetUpperBound(1); j++)
                    c_arr[i,j] = (char)rnd.Next(65, 91);

            for (int i = 0; i <= c_arr.GetUpperBound(0); i++)                                   // Вывод массива букв
            {
                for (int j = 0; j <= c_arr.GetUpperBound(0); j++)
                    Console.Write(c_arr[i,j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (char c in c_arr)                                                           // Подсчёт совпадений с алфавитом. Порядок буквы в алфавите считается индексом массива s_arr
                for (int j = 65, i = 0; j <= 90 && i <= s_arr.GetUpperBound(0); j++, i++)
                        if (Char.Equals((char)j, c))
                            s_arr[i] += 1;

            for (short i = 0, j = 65; i <= s_arr.GetUpperBound(0); i++, j++)                    // Вывод кол-ва совпадений
                Console.WriteLine($"Повторений буквы {(char)j} = {s_arr[i]}");
        }
    }
}