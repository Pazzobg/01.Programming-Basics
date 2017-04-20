using System;

namespace _06.Problem06
{
    class TwoNumbersSum
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicStop = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            bool print = false;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    sum = i + j;
                    if (sum == magicStop)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicStop})");
                        print = true;
                        break;
                    }
                }
                if (sum == magicStop) break;
            }
            if (!print) Console.WriteLine($"{counter} combinations - neither equals {magicStop}");
        }
    }
}
