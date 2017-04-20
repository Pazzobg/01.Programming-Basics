using System;

namespace _16.StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char firstChar = (char)97;
            char secondChar = (char)97;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    for (int k = firstChar; k < firstChar + b; k++)
                    {
                        for (int l = secondChar; l < secondChar + b; l++)
                        {
                            for (int m = 1; m <= a; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, (char)k, (char)l, m);
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
