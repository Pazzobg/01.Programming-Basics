using System;

namespace _16.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double priceSkumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            var pricePalamud = priceSkumria + (priceSkumria * 0.6);
            var priceSafrid = priceCaca + (priceCaca * 0.8);
            var totalPrice = (kgPalamud * pricePalamud) + (kgSafrid * priceSafrid) + (kgMidi * 7.50);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
