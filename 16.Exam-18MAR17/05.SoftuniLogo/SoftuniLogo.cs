using System;

namespace _11.SoftuniLogo
{
    class SoftuniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (12 * n - 5);
            int side = (width - 1) / 2;
            int body = 0;
            int increase = 2 * n;
            int reduce = n - 2;

            for (int i = 0; i < increase; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', side), new string('#', body));
                side -= 3;
                body += 3;
            }
            side = 3;
            body -= 6;
            for (int i = 0; i < reduce; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{2}", new string('.', side - 1), new string('#', body), new string('.', side));
                side += 3;
                body -= 3;
            }
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    Console.WriteLine("@{0}{1}#{1}{2}", new string('.', side - 1), new string('#', body), new string('.', side));
                else Console.WriteLine("|{0}{1}#{1}{2}", new string('.', side - 1), new string('#', body), new string('.', side));
            }
        }
    }
}
