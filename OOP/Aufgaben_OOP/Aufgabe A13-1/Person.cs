using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_A13_1
{
    internal class Person
    {
        public string Firstname;
        public string Lastname;
        public int Age;

        public static int counter = 0;

        public Person() 
        {
            counter++;
        }
    }
}
