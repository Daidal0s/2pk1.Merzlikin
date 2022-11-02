namespace pz._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "DataStud.txt";
            StreamReader sr = new StreamReader(path);

            string line;
            float average = 0.0f;
            
            while ((line = sr.ReadLine()) != null)
            {
                int temp = 0;
                for (int iii = 0; iii < line.Length; iii++)
                {
                    if (Char.IsNumber(line[iii]))
                    {
                        char[] Ctemp = new char[4];

                        for (byte jjj = 0; jjj <= Ctemp.GetUpperBound(0); jjj++)
                            Ctemp[jjj] = line[iii + jjj];

                        string Stemp = new string(Ctemp);
                        average += Convert.ToSingle(Stemp);

                        temp++;
                        iii += 3;
                    }
                }

                Console.WriteLine(average/temp);
                average = 0;
            }
            

        }
    }
}