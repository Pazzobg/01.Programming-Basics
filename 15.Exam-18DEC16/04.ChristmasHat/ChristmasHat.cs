using System;

namespace _08.ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotsOut = (2 * n) - 1;
            int width = (4 * n) + 1;
            Console.WriteLine("{0}/|\\{0}", new string('.', (2 * n) - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', (2 * n) - 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsOut), new string('-', i));
                dotsOut--;
            }
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', width));
        }
    }
}
