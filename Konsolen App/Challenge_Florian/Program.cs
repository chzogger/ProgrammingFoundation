namespace Challenge_Florian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> MeineZahlen = new List<int>();

            for (int c = 0; c < 10; c++)
            {
                MeineZahlen.Add(rnd.Next(1, 101));
            }

            foreach (int i in MeineZahlen)
            Console.Write(i+", ");


            int sum=0;

            foreach (int n in MeineZahlen)
            {
                sum += n;
            }

            sum /= MeineZahlen.Count;

            Console.WriteLine("\r\n" + "Summe:" + sum);

            if (sum > 50)
            {
                Console.WriteLine("Durchschittswurf über 5");
            }

            else if (sum < 50)
            {
                Console.WriteLine("Durchschnittswurf unter 5");
            }
        }

       
    }
}
