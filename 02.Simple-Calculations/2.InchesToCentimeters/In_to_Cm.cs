using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InchesToCentimeters
{
    class In_to_Cm
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inch = double.Parse(Console.ReadLine());
            var centi = inch * 2.54;
            Console.Write("centimeters = ");
            Console.WriteLine(centi);

            // drug nachin vmesto poslednite 2 reda: Console.WriteLine("centimeters = {0}",centi);
        }
    }
}
