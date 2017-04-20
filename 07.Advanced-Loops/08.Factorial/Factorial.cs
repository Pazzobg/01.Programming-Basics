using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = n; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            /*int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;

            while (num <= n)
            {
                sum *= num;
                num++;
            }
            Console.WriteLine(sum);*/
        }
    }
}
