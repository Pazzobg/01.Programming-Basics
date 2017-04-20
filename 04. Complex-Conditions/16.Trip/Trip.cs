using System;

namespace _16.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double expence = 0.00;
            string destination = "a";
            string accomodation = "a";
            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    accomodation = "Camp";
                    expence = budget * 0.30;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    expence = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    accomodation = "Camp";
                    expence = budget * 0.40;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    expence = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                accomodation = "Hotel";
                expence = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine("{0} - {1:f2}", accomodation, expence);
        }
    }
}
