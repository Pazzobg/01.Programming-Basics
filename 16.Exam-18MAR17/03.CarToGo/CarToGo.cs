using System;

namespace _11.CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string clas = "";
            string carType = "";
            double price = 0;
            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                clas = "Compact class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            else
            {
                clas = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }
            Console.WriteLine(clas);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
