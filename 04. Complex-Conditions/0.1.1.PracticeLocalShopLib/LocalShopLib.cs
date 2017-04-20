using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            var asortiment = new Dictionary<string, double>()
            {
                { "coffee", 0.50},
                { "water", 0.80},
                { "beer", 1.20},
                { "sweets", 1.45},
                { "peannuts", 1.60},
            };
            decimal result = quantity * (asortiment[firstCurrency] / currencies[secondCurrency]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
        }
    }
}