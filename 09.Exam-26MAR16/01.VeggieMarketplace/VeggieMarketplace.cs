using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.VeggieMarketplace
{
    class VeggieMarketplace
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());
            var kgVeg = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());

            var incomeVeggie = n * kgVeg;
            var incomeFruits = m * kgFruit;

            var profitEUR = (incomeVeggie + incomeFruits) / 1.94m;
            Console.WriteLine(Math.Round(profitEUR, 2));
        }
    }
}
