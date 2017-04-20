using System;

namespace _17.HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double roomSmallArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceSqMeter = double.Parse(Console.ReadLine());

            double bathroomArea = roomSmallArea / 2.0;
            double roomMiddleArea = roomSmallArea + (roomSmallArea * 0.10);
            double roomBigArea = roomMiddleArea + (roomMiddleArea * 0.10);

            double total = kitchenArea + bathroomArea + roomSmallArea + roomMiddleArea + roomBigArea;
            double totalAreaPlusCorridor = total + (total * 0.05);
            double endPrice = totalAreaPlusCorridor * priceSqMeter;

            Console.WriteLine("{0:f2}", endPrice);
        }
    }
}
