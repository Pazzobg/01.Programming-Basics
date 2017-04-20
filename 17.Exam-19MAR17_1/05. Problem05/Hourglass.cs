using System;

namespace _05.Problem05
{
    class Hourglass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 1;
            int l = n - 1;
            int dotsOut = 1;
            int mid = (2 * n) - 3;
            int spaceIn = 0;
            int full = (2 * n) - 3;

            Console.WriteLine(new string('*', width));

            for (int i = 0; i < l; i++)
            {
                if (i == 0)
                    Console.WriteLine("{0}*{1}*{0}", new string('.', dotsOut), new string(' ', mid));
                else
                    Console.WriteLine("{0}*{1}*{0}", new string('.', dotsOut), new string('@', mid));
                dotsOut++;
                mid -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            l = n - 2;
            dotsOut--;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', dotsOut), new string(' ', spaceIn));
                dotsOut--;
                spaceIn++;
            }
            Console.WriteLine(".*{0}*.", new string ('@', full));
            Console.WriteLine(new string('*', width));
        }
    }
}
