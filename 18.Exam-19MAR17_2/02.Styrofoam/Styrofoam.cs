using System;

namespace _22.Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double sqMeterPerPack = double.Parse(Console.ReadLine());
            double pricePerPack = double.Parse(Console.ReadLine());

            double workArea = (houseArea - (windows * 2.4));
            workArea += workArea * 0.10;

            double packsNeeded = Math.Ceiling(workArea / sqMeterPerPack);
            double totalPrice = packsNeeded * pricePerPack;
            double diff = Math.Abs(budget - totalPrice);

            if (totalPrice<=budget)
            {
                Console.WriteLine($"Spent: {totalPrice:f2}");
                Console.WriteLine($"Left: {diff:f2}");
            }
            else
                Console.WriteLine($"Need more: {diff:f2}");
        }
    }
}
