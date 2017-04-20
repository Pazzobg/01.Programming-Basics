using System;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1) Console.WriteLine("*");
            else if (n == 2) Console.WriteLine("**");

            else if (n % 2 == 1)
            {
                var spaces = n / 2;
                var midSpaces = 1;

                Console.Write(new string('-', spaces));
                Console.Write("*");
                Console.WriteLine(new string('-', spaces));
                spaces--;

                for (int row = 0; row < n / 2; row++)
                {
                    Console.Write(new string('-', spaces));
                    Console.Write("*");
                    Console.Write(new string('-', midSpaces));
                    Console.Write("*");
                    Console.WriteLine(new string('-', spaces));
                    spaces--;
                    midSpaces += 2;
                }
                midSpaces -= 4;
                spaces = 1;

                for (int row = 0; row < n / 2 - 1; row++)
                {
                    Console.Write(new string('-', spaces));
                    Console.Write("*");
                    Console.Write(new string('-', midSpaces));
                    Console.Write("*");
                    Console.WriteLine(new string('-', spaces));
                    spaces++;
                    midSpaces -= 2;
                }
                Console.Write(new string('-', spaces));
                Console.Write("*");
                Console.WriteLine(new string('-', spaces));
            }

            else
            {
                var spaces = (n / 2) - 1;
                var midSpaces = 2;

                Console.Write(new string('-', spaces));
                Console.Write("**");
                Console.WriteLine(new string('-', spaces));

                spaces--;

                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.Write(new string('-', spaces));
                    Console.Write("*");
                    Console.Write(new string('-', midSpaces));
                    Console.Write("*");
                    Console.WriteLine(new string('-', spaces));
                    spaces--;
                    midSpaces += 2;
                }
                midSpaces -= 4;
                spaces = 1;

                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.Write(new string('-', spaces));
                    Console.Write("*");
                    Console.Write(new string('-', midSpaces));
                    Console.Write("*");
                    Console.WriteLine(new string('-', spaces));
                    spaces++;
                    midSpaces -= 2;
                }
                Console.Write(new string('-', spaces));
                Console.Write("**");
                Console.WriteLine(new string('-', spaces));
            }
        }
    }
}
