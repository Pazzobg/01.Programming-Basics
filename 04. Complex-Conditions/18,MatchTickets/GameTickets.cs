using System;

namespace _18_MatchTickets
{
    class GameTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine().ToLower();
            int fanCount = int.Parse(Console.ReadLine());
            double moneyTransport = 0.0;

            if (fanCount >= 1 && fanCount <= 4)
            {
                moneyTransport = budget * 0.75;
            }
            else if (fanCount <= 9)
            {
                moneyTransport = budget * 0.60;
            }
            else if (fanCount <= 24)
            {
                moneyTransport = budget * 0.50;
            }
            else if (fanCount <= 49)
            {
                moneyTransport = budget * 0.40;
            }
            else if (fanCount >= 50)
            {
                moneyTransport = budget * 0.25;
            }

            double moneyTickets = budget - moneyTransport;
            double moneyNeeded = 0.0;

            if (ticketType == "vip")
            {
                moneyNeeded = fanCount * 499.99;
            }
            else if (ticketType == "normal")
            {
                moneyNeeded = fanCount * 249.99;
            }

            if (moneyTickets >= moneyNeeded)
            {
                var restBudget = moneyTickets - moneyNeeded;
                Console.WriteLine("Yes! You have {0:f2} leva left.", restBudget);
            }
            else
            {
                var shortBudget = moneyNeeded - moneyTickets;
                Console.WriteLine("Not enough money! You need {0:f2} leva.", shortBudget);
            }

        }
    }
}
