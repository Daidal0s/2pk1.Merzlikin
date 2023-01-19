namespace pz._20
{
    internal class Program
    {
        static void stringULTRA(ref string data)
        {
            char[] rawData = data.ToCharArray();
            for (int i = 0; i < rawData.Length; i++)
            {
                if (char.IsLetter(rawData[i]))
                    rawData[i] = char.IsUpper(rawData[i]) ? char.ToLower(rawData[i]) : char.ToUpper(rawData[i]);
            }
            data = new string(rawData);
        }

        static void Main(string[] args)
        {
            string data = "";
            data = Console.ReadLine();
            stringULTRA(ref data);
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}