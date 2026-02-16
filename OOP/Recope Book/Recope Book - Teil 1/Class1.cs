using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recope_Book
{
    public class Rezept
    {
        public string Name { get; set; }
        public int Zeitaufwand { get; set; }
        public string Anleitung { get; set; }

        public Rezept(string name, int zeitaufwand, string anleitung)
        {
            Name = name;
            Zeitaufwand = zeitaufwand;
            Anleitung = anleitung;
        }

        // Wichtig für die ListBox-Anzeige
        public override string ToString()
        {
            return Name;
        }
    }
}
