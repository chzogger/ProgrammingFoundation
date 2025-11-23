using System.Security.Cryptography;

namespace Superhelden_Teil1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Superhelden();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Superhelden als Klasse: ");
            MeineHelden();
           




        }

        private static void Superhelden()
        {
            List<string> SuperHelden = new List<string>();
            SuperHelden.Add("Ironman");
            SuperHelden.Add("Spiderman");
            SuperHelden.Add("Hulk");
            SuperHelden.Add("Wonder Woman");
            SuperHelden.Add("Superman");

            Console.WriteLine("Superhelden in Liste:");

            foreach (string Held in SuperHelden)
            {
                Console.WriteLine(Held);
            }

            


        }


        private static void MeineHelden()
        {
            Superheld H1 = new Superheld();
            H1.name = "Ironman";
            H1.superkraft = "Fliegen und schiessen";
            H1.level = 5;
            Console.WriteLine(H1.Ausgabe());



            Superheld H2 = new Superheld();
            H2.name = "Spiderman";
            H2.superkraft = "Spinnennetze schiessen";
            H2.level = 5;
            Console.WriteLine(H2.Ausgabe());


        }



        class Superheld
        {
            public string name { get; set; }
            public string superkraft { get; set; }
            public int level { get; set; }

            public string Ausgabe()
            {
                return "Name: " + name +
                   " | Superkraft: " + superkraft +
                   " | Level: " + level;

            }

            
        
        
        }

    }
}
