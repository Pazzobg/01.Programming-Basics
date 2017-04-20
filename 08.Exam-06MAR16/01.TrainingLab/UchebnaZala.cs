using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16.UchebnaZala
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var wUsablle = w - 1;

            var seatsPerRow = Math.Floor(wUsablle / 0.7);
            var seatsPerColumn = Math.Floor(h / 1.2);
            Console.WriteLine((seatsPerRow * seatsPerColumn) - 3);
        }
    }
}
