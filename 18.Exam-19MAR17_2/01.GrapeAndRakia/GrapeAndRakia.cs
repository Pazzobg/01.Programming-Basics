using System;

namespace _22.GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double grapePerSqM = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grapes = (grapePerSqM * area) - waste;
            double grapeRakia = grapes * 0.45;
            double grapeSell = grapes - grapeRakia;
            double rakiaProduced = grapeRakia / 7.5;

            Console.WriteLine("{0:f2}", (rakiaProduced * 9.80));
            Console.WriteLine("{0:f2}", (grapeSell * 1.50));
        }
    }
}
