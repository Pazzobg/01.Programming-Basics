using System;

namespace _01.Problem01
{
    class PaintingHouse
    {
        static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double hRoof = double.Parse(Console.ReadLine());
            double window = 1.5 * 1.5;
            double door = 1.2 * 2;

            double sidesArea = 2 * ((length * height) - window);
            double backArea = height * height;
            double frontArea = backArea - door;
            double roofSides = 2 * (length * height);
            double roofFrontBack = 2 * ((height * hRoof) / 2);

            double greenArea = sidesArea + backArea + frontArea;
            double redArea = roofSides + roofFrontBack;

            Console.WriteLine("{0:f2}", greenArea / 3.4);
            Console.WriteLine("{0:f2}", redArea / 4.3);
        }
    }
}
