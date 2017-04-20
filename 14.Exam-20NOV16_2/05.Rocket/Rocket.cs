using System;

namespace _07.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotsOut = ((3 * n) - 2) / 2;
            int spaceIn = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsOut), new string(' ', spaceIn));
                dotsOut--; spaceIn += 2;
            }
            dotsOut++; spaceIn -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsOut), new string('*', spaceIn));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', dotsOut), new string('\\', spaceIn));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsOut), new string('*', spaceIn));
                dotsOut--; spaceIn += 2;
            }
        }
    }
}
