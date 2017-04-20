using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var ha = decimal.Parse(Console.ReadLine());
            var area = (a * ha) / 2;

            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
