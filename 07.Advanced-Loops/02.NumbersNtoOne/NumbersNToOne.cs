using System;

namespace _02.NumbersNtoOne
{
    class NumbersNToOne
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
