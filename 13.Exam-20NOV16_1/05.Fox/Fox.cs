using System;

namespace _06.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaceIn = (2 * n) - 1;
            int cheek = n / 2;
            int forehead = n;
            int l = n / 3;
            int snout = (2 * n) - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', spaceIn));
                spaceIn -= 2;
            }
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', cheek), new string('*', forehead));
                cheek++;
                forehead -= 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', snout));
                snout -= 2;
            }
        }
    }
}
