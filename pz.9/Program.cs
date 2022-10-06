namespace pz._9
{
    internal class Program
    {
        static void arrPrint(ref short[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            const short a = 10;
            short b = Convert.ToInt16(rnd.Next(5, 36));

            short[][] arr = new short[2][];
            arr[0] = new short[a];
            arr[1] = new short[b];

            short[] resArr = new short[2];

            Console.WriteLine($"Длинна первой строки в ступенчатом массиве = {arr[0].Length}\nДлинна второй строки в ступенчатом массиве = {arr[1].Length}\n");

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = Convert.ToInt16(rnd.Next(0, 26));                                                               // Заполнение массивов числами от 0 до 25. Можно поставить любые числа)

            arrPrint(ref arr);                                                                                                  // Используем функцию вывода массива на экран, ибо она будет дальше использоваться не раз

            for (int i = 0; i <= resArr.GetUpperBound(0); i++)                                                                  // Заполнение нового массива последними элементами строк ступенчатого массива 
                resArr[i] = arr[i][arr[i].Length - 1];
            
            Console.WriteLine($"\nЗначения в конце строк массива => {resArr[0]}, {resArr[1]}");

            for (int i = 0; i <= resArr.GetUpperBound(0); i++)                                                                  // Перезаполнение массива новыми значениями - максимальными значениями в строке ступ. массива
                resArr[i] = arr[i].Max<short>();

            Console.WriteLine($"Максимальные значения в строках массива => {resArr[0]}, {resArr[1]}\n\nИзменённый массив:");

            for (int i = 0, j = 0, k = 0, l = 0; i < arr.Length; i++)                                                           // Тут интересно
            {                                                                                                                   //
                l = Array.IndexOf<short>(arr[i], arr[i].Max<short>());                                                          // Получаем индекс самого большого числа в строке
                j = arr[i][0];                                                                                                  // Получаем значение первого числа в строке
                k = arr[i][l];                                                                                                  // Получаем значение максимального числа в строке
                                                                                                                                // 
                arr[i][0] = Convert.ToInt16(k);                                                                                 // Меняем местами)
                arr[i][l] = Convert.ToInt16(j);
            }

            arrPrint(ref arr);

            for (int i = 0; i < arr.Length; i++)                                                                                // Ревёрсим массивы
                Array.Reverse(arr[i]);

            Console.WriteLine($"\nРевёрс массива:");

            arrPrint(ref arr);

            {                                                                                                                   // Я не хотел отавлять временно созданную перменную, что дальше никогда не понадобится в памяти((( Пусть сама себя выгрузит
                Console.WriteLine();
                float sum = 0.0f;                                                                                               // Да, эту
                for (int i = 0; i < arr.Length; i++)                                                                            // Находим среднее, суммируя числа, а потом деля на кол-во
                {
                    for (int j = 0; j < arr[i].Length; j++)
                        sum += arr[i][j];
                    Console.WriteLine($"Среднее число в {i + 1} строке массива = {(float)sum / arr[i].Length}");
                    sum = 0.0f;
                }
            }

        }
    }
}