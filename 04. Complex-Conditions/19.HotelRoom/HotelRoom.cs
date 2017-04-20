using System;

namespace _19.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            decimal priceStudio = 0.0m;
            decimal priceAppartment = 0.0m;

            if (month == "may" || month == "october")
            {
                priceStudio = 50;
                priceAppartment = 65;
            }
            else if (month == "june" || month == "september")
            {
                priceStudio = 75.20m;
                priceAppartment = 68.70m;
            }
            else if (month == "july" || month == "august")
            {
                priceStudio = 76;
                priceAppartment = 77;
            }

            if ((nights > 14 && month == "may") || (nights > 14 && month == "october"))
            {
                priceStudio = priceStudio - (priceStudio * 0.30m);
            }
            else if ((nights > 14 && month == "june") || (nights > 14 && month == "september"))
            {
                priceStudio = priceStudio - (priceStudio * 0.20m);
            }
            else if ((nights > 7 && month == "may") || (nights > 7 && month == "october"))
            {
                priceStudio = priceStudio - (priceStudio * 0.05m);
            }
            if (nights > 14)
            {
                priceAppartment = priceAppartment - (priceAppartment * 0.10m);
            }
            
            decimal totalPriceStudio = nights * priceStudio;
            decimal totalPriceAppart = nights * priceAppartment;

            Console.WriteLine("Apartment: {0:f2} lv.", totalPriceAppart);
            Console.WriteLine("Studio: {0:f2} lv.", totalPriceStudio);
        }
    }
}
