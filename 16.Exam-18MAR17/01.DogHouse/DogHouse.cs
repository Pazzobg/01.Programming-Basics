using System;

namespace _21.DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sideArea = a * (a / 2);
            double backArea = ((a / 2) * (a / 2)) + (((a / 2) * (b - (a / 2))) / 2);
            double frontArea = backArea - ((a / 5) * (a / 5));
            double roofSideArea = a * (a / 2);

            double greenPaintArea = frontArea + backArea + (sideArea * 2);
            double redPaintArea = roofSideArea * 2;

            double greenPaintLiters = greenPaintArea / 3;
            double redPaintLiters = redPaintArea / 5;

            Console.WriteLine($"{greenPaintLiters:f2}");
            Console.WriteLine("{0:f2}", redPaintLiters);
        }
    }
}
