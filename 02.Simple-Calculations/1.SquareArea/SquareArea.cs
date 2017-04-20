using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = decimal.Parse(Console.ReadLine());

            var area = a * a;

            Console.WriteLine("Square = " + area);
        }
    }
}
