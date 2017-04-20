using System;

namespace _2.ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            bool controlNumNotReached = true;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += (i * 2) + (j * 3);
                    counter++;
                    if (sum >= controlNum)
                    {
                        controlNumNotReached = false;
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNum}");
                        return;
                    }
                }
            }
            if (controlNumNotReached == true)
                Console.WriteLine($"{counter} moves");
        }
    }
}
