using System;

namespace _12.Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dotsIn = 0;
            int dotsOut = (2 * n) + 1;
            int l = (2 * n) + 1;
            int board = n - 2;

            Console.WriteLine("+{0}+{1}", new string ('~', board), new string ('.', dotsOut));
            dotsOut--;

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', dotsIn), new string ('~', board), new string('.', dotsOut));
                dotsIn++;
                dotsOut--;
            }
            dotsIn--;
            dotsOut = 0;

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string ('.', dotsOut), new string('.', dotsIn), new string('~', board));
                dotsOut++; ;
                dotsIn--;
            }
            Console.WriteLine("{0}+{1}+", new string('.', dotsOut), new string('~', board));
        }
    }
}
