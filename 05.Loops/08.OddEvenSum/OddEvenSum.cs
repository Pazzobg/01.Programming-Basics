using System;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += input;
                }
                else
                    oddSum += input;
            }
            var diff = Math.Abs(evenSum - oddSum);
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
