using System;

namespace _11._1.CinemaSolutionIF
{
    class CinemaIF
    {
        static void Main(string[] args)
        {
            string typeMovie = Console.ReadLine().ToLowerInvariant();
            int seatsRows = int.Parse(Console.ReadLine());
            int seatsColumns = int.Parse(Console.ReadLine());

            int totalSeats = seatsRows * seatsColumns;
            double price = 0.0;

            if (typeMovie == "premiere")
                price += 12.00;
            else if (typeMovie == "normal")
                price += 7.50;
            else if (typeMovie == "discount")
                price += 5.00;

            var revenue = price * totalSeats;
            Console.WriteLine($"{revenue:f2} leva");
        }
    }
}
