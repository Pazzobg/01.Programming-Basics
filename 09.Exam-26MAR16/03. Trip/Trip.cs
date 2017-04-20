using System;

namespace _02.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string tripTo = "";
            string accomodation = "";
            double expences = 0;

            if (budget <= 100)
            {
                tripTo = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    expences = budget * 0.3;
                }
                else
                {
                    accomodation = "Hotel";
                    expences = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                tripTo = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    expences = budget * 0.4;
                }
                else
                {
                    accomodation = "Hotel";
                    expences = budget * 0.8;
                }
            }
            else
            {
                tripTo = "Europe";
                accomodation = "Hotel";
                expences = budget * 0.9;
            }
            Console.WriteLine("Somewhere in {0}", tripTo);
            Console.WriteLine("{0} - {1:f2}", accomodation, expences);
        }
    }
}
