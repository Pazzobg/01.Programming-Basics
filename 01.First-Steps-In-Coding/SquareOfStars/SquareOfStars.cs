using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n < 100)
            {
                Console.WriteLine(new string('*', n));

                for (int i = 1; i <= n-2; i++)
                {
                    string rowStars = '*' + new string(' ', n - 2) + '*';
                    Console.WriteLine(rowStars);
                }

                Console.WriteLine(new string('*', n));
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
