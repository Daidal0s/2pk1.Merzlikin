namespace pz._11
{
    internal class Program
    {
        static string getName(ref string line)
        {
            string name = line.Substring(0, line.IndexOf("\t"));

            return name;
        }
        static void Main(string[] args)
        {
            const string path = "DataStud.txt";
            StreamReader sr = new StreamReader(path);

            string line;
            float average = 0.0f;
            
            while ((line = sr.ReadLine()) != null)
            {
                string name = getName(ref line);
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
                Console.WriteLine($"Средний балл студента {name}\t=\t{(average/temp)}");
                average = 0;
            }
            

        }
    }
}