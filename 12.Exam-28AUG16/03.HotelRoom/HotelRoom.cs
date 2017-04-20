using System;

namespace _4._19.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());
            var pricePerNghtStd = 0.0;
            var pricePerNghtApp = 0.0;

            if (month == "may" || month == "october")
            {
                pricePerNghtStd = 50;
                pricePerNghtApp = 65;
                if (nights > 14)
                {
                    pricePerNghtStd -= pricePerNghtStd * 0.3;
                }
                else if (nights > 7)
                {
                    pricePerNghtStd -= pricePerNghtStd * 0.05;
                }
            }
            else if (month == "june" || month == "september")
            {
                pricePerNghtStd = 75.20;
                pricePerNghtApp = 68.70;
                if (nights > 14)
                {
                    pricePerNghtStd -= pricePerNghtStd * 0.2;
                }
            }
            else if (month == "july" || month == "august")
            {
                pricePerNghtStd = 76;
                pricePerNghtApp = 77;
            }

            if (nights > 14)
            {
                pricePerNghtApp -= pricePerNghtApp * 0.1;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", (nights * pricePerNghtApp));
            Console.WriteLine("Studio: {0:f2} lv.", (nights * pricePerNghtStd));

        }
    }
}
