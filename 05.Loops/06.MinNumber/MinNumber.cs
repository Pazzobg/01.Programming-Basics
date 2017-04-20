using System;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentMin = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < currentMin)
                {
                    currentMin = input;
                }
            }
            Console.WriteLine(currentMin);
        }
    }
}
