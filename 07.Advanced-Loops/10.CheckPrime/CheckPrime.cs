using System;

namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            int divider = 2;
            var maxDivider = Math.Sqrt(n);
            var result = 1;
            if (n < 2)
            {
                prime = false;
            }
            else
            {
                while (prime && (divider <= maxDivider))
                {
                    result = n % divider;
                    if (result == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
            }
            if (prime == true)
            {
                Console.WriteLine("Prime");
            }
            else
                Console.WriteLine("Not prime");
        }
    }
}
