using System;

namespace _02.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = n - 2;
            int wing = n - 2;
            char space = ' ';

            for (int i = 0; i < l; i++)
            {
                if (i % 2 == 0) Console.WriteLine("{0}\\{1}/{0}", new string('*', wing), new string(space, 1));
                else Console.WriteLine("{0}\\{1}/{0}", new string('-', wing), new string(space, 1));
            }
            Console.WriteLine("{0}@", new string(' ', n - 1));
            for (int i = 0; i < l; i++)
            {
                if (i % 2 == 0) Console.WriteLine("{0}/{1}\\{0}", new string('*', wing), new string(space, 1));
                else Console.WriteLine("{0}/{1}\\{0}", new string('-', wing), new string(space, 1));
            }
        }
    }
}
