using System;

namespace _22.MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    if (combinations == maxCombinations) break;
                    combinations++;
                    Console.Write($"<{i}-{j}>");
                }
                if (combinations == maxCombinations) break;
            }
            Console.WriteLine();
        }
    }
}
