using System;

namespace _02.Problem02
{
    class Cups
    {
        static void Main()
        {
            int cupsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workdays = int.Parse(Console.ReadLine());

            double workHours = workers * 8 * workdays;
            double cupsMade = Math.Floor(workHours / 5);

            double diff = Math.Abs(cupsMade - cupsNeeded);
            double moneyDiff = diff * 4.20;

            if (cupsNeeded <= cupsMade)
            {
                Console.WriteLine($"{moneyDiff:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {moneyDiff:f2}");
            }
        }
    }
}
