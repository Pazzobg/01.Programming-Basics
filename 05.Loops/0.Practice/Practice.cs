using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var maxDiff = 0;
            var prevSum = 0;
            var sum = 0;
            var diff = 0;

            for (int i = 0; i < n; i++)
            {
                prevSum = sum;
                var a = int.Parse(Console.ReadLine()); 
                var b = int.Parse(Console.ReadLine());
                sum = a + b;

                if (i == 0)
                    continue;
                else
                    diff = Math.Abs(sum - prevSum);
                if (diff > maxDiff)
                    maxDiff = diff;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, \nvalue = {sum}");
            }
            else
            {
                Console.WriteLine($"No, \nmaxdiff = {maxDiff}");
            }
        }
    }
}