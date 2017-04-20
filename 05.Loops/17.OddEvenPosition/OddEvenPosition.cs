using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var input = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += input;
                    if (input < oddMin)
                    {
                        oddMin = input;
                    }
                    if (input > oddMax)
                    {
                        oddMax = input;
                    }
                }
                else
                {
                    evenSum += input;
                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                    if (input > evenMax)
                    {
                        evenMax = input;
                    }
                }
            }

            Console.WriteLine($"OddSum = {oddSum}");
            if (oddMin != double.MaxValue)
                Console.WriteLine($"OddMin = {oddMin}");
            else
                Console.WriteLine("OddMin = No");
            if (oddMax != double.MinValue)
                Console.WriteLine($"OddMax = {oddMax}");
            else
                Console.WriteLine("OddMax = No");
            Console.WriteLine($"EvenSum = {evenSum}");
            if (evenMin != double.MaxValue)
                Console.WriteLine($"EvenMin = {evenMin}");
            else
                Console.WriteLine("EvenMin = No");
            if (evenMax != double.MinValue)
                Console.WriteLine($"EvenMax = {evenMax}");
            else
                Console.WriteLine("EvenMax = No");
        }
    }
}
