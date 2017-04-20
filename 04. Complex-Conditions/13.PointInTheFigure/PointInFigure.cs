using System;

namespace _13.PointInTheFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x > 0 && x < 3*h && y > 0 && y < h) || (x > h && x < 2 * h && y > h && y < 4 * h) || (y == h && x > h && x < 2 * h) )
            {
                Console.WriteLine("inside");
            }
            else if ((x < 0 || x > 3 * h || y < 0 || y > h) && (x < h || x > 2 * h || y < h || y > 4 * h))
            {
                Console.WriteLine("outside");
            }
            else
                Console.WriteLine("border");
        }
    }
}
