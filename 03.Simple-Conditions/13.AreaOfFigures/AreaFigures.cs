using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class AreaFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * a), 3));
            }

            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b), 3));
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI * r * r), 3));
            }

            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var ha = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * ha / 2), 3));
            }
        }
    }
}
