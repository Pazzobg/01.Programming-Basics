using System;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Roof
            if (n % 2 != 0)
            {
                var stars = 1;
                for (int row = 1; row < (n + 1) / 2; row++)
                {
                    for (int col = 0; col <= (n / 2) - row; col++)
                    {
                        Console.Write("-");
                    }
                    Console.Write(new string('*', stars));
                    stars += 2;

                    for (int col = 0; col <= (n / 2) - row; col++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('*', n));
            }
            else
            {
                var stars = 2;
                for (int row = 1; row < (n + 1) / 2; row++)
                {
                    for (int col = 0; col < (n / 2) - row; col++)
                    {
                        Console.Write("-");
                    }
                    Console.Write(new string('*', stars));
                    stars += 2;

                    for (int col = 0; col < (n / 2) - row; col++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('*', n));
            }

            //House Body
            for (int i = 0; i <= (n / 2) - 1; i++)
            {
                Console.WriteLine('|' + new string('*', n - 2) + '|');
            }
        }
    }
}
