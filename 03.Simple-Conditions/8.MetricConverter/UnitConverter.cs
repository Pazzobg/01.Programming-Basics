using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MetricConverter
{
    class UnitConverter
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var unitIn = Console.ReadLine().ToLower();
            var unitOut = Console.ReadLine().ToLower();

            if (unitIn == "m")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input * 1000} mm");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input * 100} cm");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input * 39.3700787} in");
                else if (unitOut == "km")
                    Console.WriteLine($"{input * 0.001} km");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input * 3.2808399} ft");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input * 1.0936133} yd");
            }

            else if (unitIn == "mm")
            {
                if (unitOut == "m")
                    Console.WriteLine($"{input / 1000} m");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input / 10} cm");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input / 1000 * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input / 1000 * 39.3700787} in");
                else if (unitOut == "km")
                    Console.WriteLine($"{input / 1000000} km");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input / 1000 * 3.2808399} ft");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input / 1000 * 1.0936133} yd");
            }

            else if (unitIn == "cm")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input * 10} mm");
                else if (unitOut == "m")
                    Console.WriteLine($"{input / 100} m");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input / 100 * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input / 100 * 39.3700787} in");
                else if (unitOut == "km")
                    Console.WriteLine($"{input / 100 * 0.001} km");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input / 100 * 3.2808399} ft");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input / 100 * 1.0936133} yd");
            }

            else if (unitIn == "mi")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input / 0.000621371192 * 1000} mm");
                if (unitOut == "cm")
                    Console.WriteLine($"{input / 0.000621371192 * 100} cm");
                if (unitOut == "m")
                    Console.WriteLine($"{input / 0.000621371192} m");
                if (unitOut == "in")
                    Console.WriteLine($"{input / 0.000621371192 * 39.3700787} in");
                if (unitOut == "km")
                    Console.WriteLine($"{input / 0.000621371192 * 0.001} km");
                if (unitOut == "ft")
                    Console.WriteLine($"{input / 0.000621371192 * 3.2808399} ft");
                if (unitOut == "yd")
                    Console.WriteLine($"{input / 0.000621371192 * 1.0936133} yd");
            }

            else if (unitIn == "in")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input / 39.3700787 * 1000} mm");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input / 39.3700787 * 100} cm");
                else if(unitOut == "mi")
                    Console.WriteLine($"{input / 39.3700787 * 0.000621371192} mi");
                else if (unitOut == "m")
                    Console.WriteLine($"{input / 39.3700787} m");
                else if (unitOut == "km")
                    Console.WriteLine($"{input / 39.3700787 * 0.001} km");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input / 39.3700787 * 3.2808399} ft");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input / 39.3700787 * 1.0936133} yd");
            }

            else if (unitIn == "km")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input / 0.001 * 1000} mm");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input / 0.001 * 100} cm");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input / 0.001 * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input / 0.001 * 39.3700787} in");
                else if (unitOut == "m")
                    Console.WriteLine($"{input * 1000} m");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input / 0.001 * 3.2808399} ft");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input / 0.001 * 1.0936133} yd");
            }

            else if (unitIn == "ft")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input / 3.2808399 * 1000} mm");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input / 3.2808399 * 100} cm");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input / 3.2808399 * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input / 3.2808399 * 39.3700787} in");
                else if (unitOut == "km")
                    Console.WriteLine($"{input / 3.2808399 * 0.001} km");
                else if (unitOut == "m")
                    Console.WriteLine($"{input / 3.2808399} m");
                else if (unitOut == "yd")
                    Console.WriteLine($"{input / 3.2808399 * 1.0936133} yd");
            }

            else if (unitIn == "yd")
            {
                if (unitOut == "mm")
                    Console.WriteLine($"{input / 1.0936133 * 1000} mm");
                else if (unitOut == "cm")
                    Console.WriteLine($"{input / 1.0936133 * 100} cm");
                else if (unitOut == "mi")
                    Console.WriteLine($"{input / 1.0936133 * 0.000621371192} mi");
                else if (unitOut == "in")
                    Console.WriteLine($"{input / 1.0936133 * 39.3700787} in");
                else if (unitOut == "km")
                    Console.WriteLine($"{input / 1.0936133 * 0.001} km");
                else if (unitOut == "ft")
                    Console.WriteLine($"{input / 1.0936133 * 3.2808399} ft");
                else if (unitOut == "m")
                    Console.WriteLine($"{input / 1.0936133} m");
            }

            else
                Console.WriteLine("Please put numeric value on position one and choose one of the following units to convert to and/or from: m, mm, cm, mi, in, km, ft, yd. Plese use lowercase!");

            if (unitIn == unitOut)
            {
                Console.WriteLine(input);
            }
        }
    }
}
