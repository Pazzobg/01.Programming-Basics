using System;

namespace _18.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileBase = double.Parse(Console.ReadLine());
            double tileH = double.Parse(Console.ReadLine());
            double singlePrice = double.Parse(Console.ReadLine());
            double workerPrice = double.Parse(Console.ReadLine());

            var floorArea = floorLength * floorWidth;
            var tileArea = (tileBase * tileH) / 2;
            var tileNumber = (Math.Ceiling(floorArea / tileArea)) + 5;
            var totalPrice = (tileNumber * singlePrice) + workerPrice;
            var difference = Math.Abs(money - totalPrice);

            if (totalPrice <= money) Console.WriteLine("{0:f2} lv left.", difference);
            else Console.WriteLine("You'll need {0:f2} lv more.", difference);
        }
    }
}
