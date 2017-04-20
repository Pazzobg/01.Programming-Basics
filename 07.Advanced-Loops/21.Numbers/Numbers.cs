using System;

namespace _21.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int thirdDigit = n % 10;

            int secondDigit = n / 10;
            secondDigit = secondDigit % 10;

            int firstDigit = (n / 10);
            firstDigit = firstDigit / 10;

            int row = firstDigit + secondDigit;
            int col = firstDigit + thirdDigit;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n += thirdDigit;
                        Console.Write("{0} ", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
