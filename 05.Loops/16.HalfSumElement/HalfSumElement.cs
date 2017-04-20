using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum = int.MinValue;
            int sumOthers = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sumOthers += input;

                if (input > biggestNum)
                    biggestNum = input;
            }
            sumOthers -= biggestNum;
            var diff = Math.Abs(biggestNum - sumOthers);
            if (biggestNum == sumOthers)
            {
                Console.WriteLine($"Yes\nSum = {biggestNum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {diff}");
            }
        }
    }
}
