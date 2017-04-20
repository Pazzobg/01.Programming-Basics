using System;

namespace _2._20.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitCoin = int.Parse(Console.ReadLine());
            var cNY = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bgn = (bitCoin * 1168) + ((cNY * 0.15) * 1.76);
            var eur = bgn / 1.95;
            Console.WriteLine(eur - ((eur / 100) * commission));
        }
    }
}
