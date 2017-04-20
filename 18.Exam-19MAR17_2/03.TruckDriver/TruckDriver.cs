using System;

namespace _12.TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double salary = 0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn": salary = kmPerMonth * 0.75; break;
                    case "summer": salary = kmPerMonth * 0.90; break;
                    case "winter": salary = kmPerMonth * 1.05; break;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn": salary = kmPerMonth * 0.95; break;
                    case "summer": salary = kmPerMonth * 1.10; break;
                    case "winter": salary = kmPerMonth * 1.25; break;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                salary = kmPerMonth * 1.45;
            }

            salary -= salary * 0.10;
            salary *= 4;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
