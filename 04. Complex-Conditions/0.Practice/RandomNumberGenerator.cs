using System;

namespace _0.Practice
{
    class RandomNumberGenerator
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(min, max));
        }
    }
}
