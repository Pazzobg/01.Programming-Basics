using System;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            var numPrev = 1;
            var sum = 1;

            for (int i = 1; i < n; i++)
            {
                sum = numPrev + num;
                num = numPrev;
                numPrev = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
