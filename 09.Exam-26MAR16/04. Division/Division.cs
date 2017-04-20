using System;

namespace _03.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double divide2 = 0;
            double divide3 = 0;
            double divide4 = 0; 

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input % 2 == 0) divide2 += 1;
                if (input % 3 == 0) divide3 += 1;
                if (input % 4 == 0) divide4 += 1;
            }

            Console.WriteLine("{0:f2}%", ((divide2 / n) * 100));
            Console.WriteLine("{0:f2}%", ((divide3 / n) * 100));
            Console.WriteLine("{0:f2}%", ((divide4 / n) * 100));
        }
    }
}
