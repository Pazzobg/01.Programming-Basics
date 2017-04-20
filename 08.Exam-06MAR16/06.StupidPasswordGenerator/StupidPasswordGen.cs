using System;

namespace _16.StupidPasswordGenerator
{
    class StupidPasswordGen
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int lettersEnd = 'a' + l;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char a = 'a'; a < lettersEnd; a++)
                    {
                        for (char b = 'a'; b < lettersEnd; b++)
                        {
                            for (int k = 1; k <= n; k++)
                            {
                                if (k > i && k > j)
                                {
                                    Console.Write($"{i}{j}{a}{b}{k} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
