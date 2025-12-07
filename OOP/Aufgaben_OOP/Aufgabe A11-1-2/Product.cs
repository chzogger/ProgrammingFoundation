using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_A11_1_2
{
    public class Product
    {
        public string name;
        public double purchasingPrice;
        public double retailPrice;

        public string ShowValues()
        {
            return name + ",   EP: " + purchasingPrice + ".- CHF,   VP: " + retailPrice + ".- CHF" + Environment.NewLine;


        }

    }
}
