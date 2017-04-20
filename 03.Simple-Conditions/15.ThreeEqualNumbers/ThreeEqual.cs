using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ThreeEqualNumbers
{
    class ThreeEqual
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (a == b)
            {
                if (a == c)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }

            else if (b == c)
            {
                if (b == a)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }

            else if (c == a)
            {
                if (c == b)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }

            else
                Console.WriteLine("no");
        }
    }
}
