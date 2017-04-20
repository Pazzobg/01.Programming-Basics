using System;

namespace _03.Problem03
{
    class Vacation
    {
        static void Main()
        {    // AKO NE IZLIZA DA VIDQ S DECIMAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string destination = "";
            string accomodation = "";
            double price = 0;

            if (budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "summer")
                {
                    destination = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "winter")
                {
                    destination = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accomodation = "Hut";
                if (season == "summer")
                {
                    destination = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "winter")
                {
                    destination = "Morocco";
                    price = budget * 0.60;
                }
            }
            else
            {
                accomodation = "Hotel";
                price = budget * 0.90;
                if (season == "summer") destination = "Alaska";
                else if (season == "winter") destination = "Morocco";
            }
            Console.WriteLine($"{destination} - {accomodation} - {price:f2}");
        }
    }
}
