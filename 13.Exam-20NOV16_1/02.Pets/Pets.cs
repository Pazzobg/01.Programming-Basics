using System;

namespace _16.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodDogPerDay = double.Parse(Console.ReadLine());
            double foodCatPerDay = double.Parse(Console.ReadLine());
            double foodTurtPerDay = (double.Parse(Console.ReadLine()) / 1000);
            var foodNeeded = (foodDogPerDay + foodCatPerDay + foodTurtPerDay) * days;
            var difference = Math.Abs(foodLeft - foodNeeded);

            if (foodLeft >= foodNeeded)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(difference));
            }

        }
    }
}
