using System;

namespace _20.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int inputBreak = input;
            int thirdDigit = inputBreak % 10;
            inputBreak /= 10;
            int secondDigit = inputBreak % 10;
            inputBreak /= 10;
            int firstDigit = inputBreak % 10;
            int rowLength = firstDigit + secondDigit;
            int colLength = firstDigit + thirdDigit;

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (input % 5 == 0) input -= firstDigit;
                    else if (input %3 == 0) input -= secondDigit;
                    else input += thirdDigit;
                    Console.Write($"{input} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
