using System;

namespace _6._10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 0;
            int spacesOut = ((n + 1) / 2) - 1;
            int spacesIn = 0;
            if (n % 2 != 0) { stars = 1; spacesIn = 1; }
            else { stars = 2; spacesIn = 2; }
            if (n == 1)
                Console.WriteLine("*");
            else if (n == 2)
                Console.WriteLine("**");
            else
            {
                Console.WriteLine(new string('-', spacesOut) + new string('*', stars) + new string('-', spacesOut));
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    spacesOut--;
                    Console.WriteLine(new string('-', spacesOut) + "*" + new string('-', spacesIn) + "*" + new string('-', spacesOut));
                    spacesIn += 2;
                }
                spacesIn -= 4;
                spacesOut = 1;
                for (int i = 0; i < ((n + 1) / 2) - 2; i++)
                {
                    Console.WriteLine(new string('-', spacesOut) + "*" + new string('-', spacesIn) + "*" + new string('-', spacesOut));
                    spacesIn -= 2;
                    spacesOut++;
                }
                Console.WriteLine(new string('-', spacesOut) + new string('*', stars) + new string('-', spacesOut));
            }
        }
    }
}
