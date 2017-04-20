using System;

namespace _22.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int battles = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (battles == maxBattles) break;
                    Console.Write("({0} <-> {1}) ", i, j);
                    battles++;
                }
            }
            Console.WriteLine();
        }
    }
}
