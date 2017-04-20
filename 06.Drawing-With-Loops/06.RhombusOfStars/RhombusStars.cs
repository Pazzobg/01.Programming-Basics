using System;

namespace _06.RhombusOfStars
{
    class RhombusStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Top part

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


            //Bottom part

            for (int row = 1; row <= n - 1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 1; col <= (n - row - 1); col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
