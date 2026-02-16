using System.Security.Cryptography;

namespace Noten_Analyse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] Noten = new double[10];
            double sum = 0;
            double ergebnis = 0;

            foreach (int n in Noten)
            { 
            Random r = new Random();
            double note = r.Next(2,7);
                Noten[n] = note;
                
                sum += note;

                Console.WriteLine(note.ToString() + " " + "Summe:" + sum.ToString());
                ergebnis = sum / Noten.Length;

                

            }

            if (ergebnis > 4)
            {
                Console.WriteLine("Der Schnitt ist genügend");
            }
            else if (ergebnis < 4)

            {
                Console.WriteLine("Der Schnitt ist genügend: " + ergebnis.ToString());
            }


        }
    }
}
