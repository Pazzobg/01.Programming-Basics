using System;

namespace _07.BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double taxJunior = 0;
            double taxSenior = 0;

            if (track == "trail")
            {
                taxJunior += 5.50;
                taxSenior += 7;
            }
            else if (track == "cross-country")
            {
                taxJunior += 8;
                taxSenior += 9.50;
            }
            else if (track == "downhill")
            {
                taxJunior += 12.25;
                taxSenior += 13.75;
            }
            else if (track == "road")
            {
                taxJunior += 20;
                taxSenior += 21.50;
            }
            double totalCollected = (juniors * taxJunior) + (seniors * taxSenior);
            if (track == "cross-country" && ((juniors + seniors) >= 50)) totalCollected -= (totalCollected * 0.25);
            double donationTotal = totalCollected - (totalCollected * 0.05);
            Console.WriteLine("{0:f2}", donationTotal);
        }
    }
}
