using System;

namespace _6._16.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', i), new string('-', (2 * n) - i - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', 3 * n), new string('-', n - 1));
            }

            //BottomBlade n/2 - 1
            int spaceBefore = 3 * n;
            int spaceIn = n - 1;
            int spaceAft = n - 1;
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', spaceBefore), new string('-',spaceIn), new string ('-', spaceAft));
                spaceBefore--;
                spaceIn += 2;
                spaceAft--;
            }
            //EndRow
            Console.WriteLine("{0}*{1}*{2}", new string('-', spaceBefore), new string('*', spaceIn), new string('-', spaceAft));
        }
    }
}
