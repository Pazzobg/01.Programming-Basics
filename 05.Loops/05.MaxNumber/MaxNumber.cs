using System;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentMax = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                int numInput = int.Parse(Console.ReadLine());
                if (numInput > currentMax)
                {
                    currentMax = numInput;
                }
            }
            Console.WriteLine(currentMax);
        }
    }
}
