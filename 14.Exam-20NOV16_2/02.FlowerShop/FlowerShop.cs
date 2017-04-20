using System;

namespace _17.FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            double magnolia = (int.Parse(Console.ReadLine()) * 3.25);
            double zumbuls = (int.Parse(Console.ReadLine()) * 4.0);
            double roses = (int.Parse(Console.ReadLine()) * 3.50);
            double cacti = (int.Parse(Console.ReadLine()) * 8);
            double giftPrice = double.Parse(Console.ReadLine());

            double orderTotal = magnolia + zumbuls + roses + cacti;
            double orderAftTax = orderTotal * 0.95;
            double difference = Math.Abs(giftPrice - orderAftTax);
            if (giftPrice <= orderAftTax) Console.WriteLine("She is left with {0} leva.", Math.Floor(difference));
            else Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(difference));
        }
    }
}
