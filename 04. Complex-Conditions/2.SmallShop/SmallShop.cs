using System;

namespace _2.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (city == "sofia")
            {
                if (product == "coffee")
                    price += 0.5;
                if (product == "water")
                    price += 0.8;
                if (product == "beer")
                    price += 1.2;
                if (product == "sweets")
                    price += 1.45;
                if (product == "peanuts")
                    price += 1.6;
            }

            else if (city == "plovdiv")
            {
                if (product == "coffee")
                    price += 0.4;
                if (product == "water")
                    price += 0.7;
                if (product == "beer")
                    price += 1.15;
                if (product == "sweets")
                    price += 1.3;
                if (product == "peanuts")
                    price += 1.50;
            }

            else if (city == "varna")
            {
                if (product == "coffee")
                    price += 0.45;
                if (product == "water")
                    price += 0.70;
                if (product == "beer")
                    price += 1.10;
                if (product == "sweets")
                    price += 1.35;
                if (product == "peanuts")
                    price += 1.55;
            }

            Console.WriteLine(quantity * price);
        }
    }
}
