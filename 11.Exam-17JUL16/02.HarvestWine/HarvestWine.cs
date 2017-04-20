using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            var areaLoze = int.Parse(Console.ReadLine());
            var areaWine = areaLoze * 0.40;
            var grozdePerSqM = float.Parse(Console.ReadLine());
            var neededWineLiters = int.Parse(Console.ReadLine());
            var numWorkers = int.Parse(Console.ReadLine());

            var producedWine = (areaWine * grozdePerSqM) / 2.5;

            if (producedWine < neededWineLiters)
            {
                var wineShortage = neededWineLiters - producedWine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineShortage)} liters wine needed.");
            }
            else
            {
                var wineForShare = producedWine - neededWineLiters;
                var wineForOne = wineForShare / numWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineForShare)} liters left -> {Math.Ceiling(wineForOne)} liters per person.");
            }
        }
    }
}
