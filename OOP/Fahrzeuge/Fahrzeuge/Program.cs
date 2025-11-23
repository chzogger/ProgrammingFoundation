using System.Reflection.Emit;
using System.Xml.Linq;

namespace Fahrzeuge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeinFahrzeug();
            
        }


        private static void MeinFahrzeug()
        {
            List<Fahrzeuge> FahrzeugListe = new List<Fahrzeuge>();

            
            Fahrzeuge F1 = new Fahrzeuge();
            F1.kategorie = "Bus";
            F1.marke = "Volvo";
            F1.baujahr = 2018;
            F1.kosten = "günstig";
            F1.fortbewegung = "im öffentlichen Verkehr";

            
            Fahrzeuge F2 = new Fahrzeuge();
            F2.kategorie = "Auto";
            F2.marke = "Audi";
            F2.baujahr = 2021;
            F2.kosten = "teuer";
            F2.fortbewegung = "auf der Straße";

            
            Fahrzeuge F3 = new Fahrzeuge();
            F3.kategorie = "Motorrad";
            F3.marke = "Honda";
            F3.baujahr = 2015;
            F3.kosten = "mittel";
            F3.fortbewegung = "auf zwei Rädern";

            Fahrzeuge F4 = new Fahrzeuge();
            F4.kategorie = "Mountain Bike";
            F4.marke = "TREK";
            F4.baujahr = 2024;
            F4.kosten = "günstig";
            F4.fortbewegung = "im Wald";

            Fahrzeuge F5 = new Fahrzeuge();
            F5.kategorie = "Privatjet";
            F5.marke = "Pilatus";
            F5.baujahr = 2010;
            F5.kosten = "extrem teuer";
            F5.fortbewegung = "nicht, sondern fliegt";

           
            FahrzeugListe.Add(F1);
            FahrzeugListe.Add(F2);
            FahrzeugListe.Add(F3);
            FahrzeugListe.Add(F4);
            FahrzeugListe.Add(F5);

           
            foreach (Fahrzeuge f in FahrzeugListe)
            {
                Console.WriteLine(f.fahren());
            }
        }

        public class Fahrzeuge
        {
            public string kategorie;
            public string marke;
            public int baujahr;
            public string kosten;
            public string fortbewegung;

            public string fahren()
            {
                return "Mein " + kategorie +
                       " (" + marke + ", Jahr " + baujahr + ")" +
                       " fährt " + fortbewegung + ".";
            }
        }
    }
}
