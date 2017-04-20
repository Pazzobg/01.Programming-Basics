using System;

namespace _07.GreatestCommonDivisor
{
    class GretestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b!=0)
            {
                var tempRemainder = a % b;
                a = b;
                b = tempRemainder;
            }
            Console.WriteLine(a);
        }
    }
}
