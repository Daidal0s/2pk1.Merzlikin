namespace pz._28
{
    internal class Program
    {
        public static void TemperatureOnCurrentPosition(object sender, ACEventArgs e)
        {
            if (e.Value == -25 || e.Value == 0 || e.Value == 25 || e.Value == 35)
                Console.WriteLine("Теперь значение на градуснике " + e.Value);
        }

        static void Main(string[] args)
        {
            AC ac = new AC(-30, TemperatureOnCurrentPosition);

            for (int i = 0; i <= 80; ++i) 
            {
                ac.increaseTemparature(1);
                Console.WriteLine($"{i}. ");
            }
        }
    }
}