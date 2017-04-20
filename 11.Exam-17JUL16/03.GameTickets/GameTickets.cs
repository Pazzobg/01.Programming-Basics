using System;

namespace _4._18.GameTickets
{
    class GameTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var numberFans = int.Parse(Console.ReadLine());
            var transpoPrice = 0.0;
            var ticketprice = 0.0;

            if (numberFans <= 4)
                transpoPrice = budget * 0.75;
            else if (numberFans > 4 && numberFans <= 9)
                transpoPrice = budget * 0.60;
            else if (numberFans > 9 && numberFans <= 24)
                transpoPrice = budget * 0.50;
            else if (numberFans > 24 && numberFans <= 49)
                transpoPrice = budget * 0.40;
            else 
                transpoPrice = budget * 0.25;

            var moneyLeft = budget - transpoPrice;

            if (category == "vip")
            {
                ticketprice = 499.99;
                if (moneyLeft > numberFans * ticketprice)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (moneyLeft - (numberFans * ticketprice)));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", ((numberFans * ticketprice) - moneyLeft));
                }
            }
            else if (category == "normal")
            {
                ticketprice = 249.99;
                if (moneyLeft > numberFans * ticketprice)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (moneyLeft - (numberFans * ticketprice)));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", ((numberFans * ticketprice) - moneyLeft));
                }
            }
        }
    }
}
