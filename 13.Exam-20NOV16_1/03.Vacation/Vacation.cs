using System;

namespace _06.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transpo = Console.ReadLine().ToLower();
            double priceStudentsOW = 0.0;
            double priceAdultsOW = 0.0;

            if (transpo == "train")
            {
                priceAdultsOW += 24.99;
                priceStudentsOW += 14.99;
            }
            else if (transpo == "bus")
            {
                priceAdultsOW += 32.50;
                priceStudentsOW += 28.50;
            }
            else if (transpo == "boat")
            {
                priceAdultsOW += 42.99;
                priceStudentsOW += 39.99;
            }
            else if (transpo == "airplane")
            {
                priceAdultsOW += 70;
                priceStudentsOW += 50;
            }
            double transpoExpences = ((adults * priceAdultsOW) + (students * priceStudentsOW)) * 2;
            if (transpo == "train" && (adults + students >= 50)) transpoExpences /= 2;
            double accomodationExpences = nights * 82.99;
            double totalPrice = transpoExpences + accomodationExpences;
            double grandTotal = totalPrice += (totalPrice * 0.10);

            Console.WriteLine("{0:f2}", grandTotal);
        }
    }
}
