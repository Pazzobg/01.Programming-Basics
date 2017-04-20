using System;

namespace _04.CleverLilly
{
    class CleverLilly
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toySglPrice = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            int money = 0;
            double totalMoney = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += (i * 5);
                    money--;
                }
                else
                    toyCounter++;
            }
            totalMoney = money + (toyCounter * toySglPrice);
            var diff = Math.Abs(totalMoney - price);

            if (totalMoney >= price) Console.WriteLine("Yes! {0:f2}", diff);
            else Console.WriteLine("No! {0:f2}", diff);
        }
    }
}
