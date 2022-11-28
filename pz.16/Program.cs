namespace pz._16
{
    internal class Program
    {
        static string getRawData()
        {
            using (StreamReader sr = new StreamReader("DataStud.txt"))
            {
                string rawData = sr.ReadToEnd();
                return rawData;
            }
        }
        static void getArScoreAndNames(out float arScore, out string names)
        {
            string rawData = getRawData();
            rawData = rawData.Replace('\r', ' ');
            string subData = "";

            

            for (int iii = 0; iii < rawData.Length; iii++)
            {
                if (Char.Equals(rawData[iii], '\n'))
                {
                    subData = rawData.Substring(0, iii);
                    rawData = rawData.Remove(0, iii+1);

                    if (Convert.ToSingle(subData.Substring(subData.Length - 1 - 4, 1)) < 3.00f)
                    { }

                }
            }
            arScore = 0;
            names = subData;
            Console.WriteLine(rawData);
        }
        static void getLowskillStud()
        {
            
        }

        static float getAverageScore()
        {
            float score = 0.0f;
            return score;
        }
        static void Main(string[] args)
        {
            string names = "";
            float score = 0.0f;
            Console.WriteLine("Оценка по контрольной работе ниже тройки у следующих учащихся: ");
            getArScoreAndNames(out score, out names);
            Console.WriteLine($"Средний балл по контрольной у учащихся: {getAverageScore()*100.0/1/100.0}");
        }
    }
}