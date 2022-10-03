using System;

namespace pz._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            short[] arr = new short[10];

            for (short i = 0; i < arr.GetUpperBound(0); i++)
                arr[i] = (short)rnd.Next(0, 51);

            // Из-за того, что на компьютере в 407 проблемы с .NET, метод Array.Sort() мне не доступен. Пришлось сортировать так)

            for (short i = 0, tempOne = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (short j = (short)(i + 1); j <= arr.GetUpperBound(0); j++)
                {
                    if ((arr[i] % 10) + (arr[i] / 10) > (arr[j] % 10) + (arr[j] / 10))      // Если сумма цифр первого элемента больше суммы цифр следующего
                    {
                        tempOne = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tempOne;
                    }
                }
            }

            for (short i = 0, temp = 1; i <= arr.GetUpperBound(0); i++, temp++)
            {
                Console.WriteLine($"Элемент массива {temp} = {arr[i]}\tСумма цифр = {(arr[i] % 10) + (arr[i] / 10)}");
            }

        }
    }
}
