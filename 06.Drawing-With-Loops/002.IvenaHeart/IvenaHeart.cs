using System;
using System.Threading;

namespace _002.IvenaHeart
{
    class IvenaHeart
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var c = (char)3;

            var space = 2;
            var star = n - 4;
            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string(c, star));
                Console.Write(new string(' ', space));
                Console.Write(new string(' ', space));
                Console.Write(new string(c, star));
                Console.WriteLine(new string(' ', space));
                Thread.Sleep(450);
                space--;
                star += 2;
            }

            space = 0;
            star = 2 * n;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string(c, star));

                space++;
                star -= 2;
                Thread.Sleep(450);
                Console.WriteLine();
            }
        }
    }
}
