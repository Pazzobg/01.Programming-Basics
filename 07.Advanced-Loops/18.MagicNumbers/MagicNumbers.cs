using System;

namespace _18.MagicNumbers
{
    class MagicNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int o = 1; o <= 9; o++)
                            {
                                for (int p = 1; p <= 9; p++)
                                {
                                    if (i * j * l * m * o * p == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, l, m, o, p);
                                    }
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
