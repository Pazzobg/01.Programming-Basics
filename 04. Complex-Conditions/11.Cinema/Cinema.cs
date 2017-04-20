using System;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeMovie = Console.ReadLine();
            int seatsRows = int.Parse(Console.ReadLine());
            int seatsColumns = int.Parse(Console.ReadLine());
            int totalSeats = seatsRows * seatsColumns;
            double price = 0.0;

            switch (typeMovie)
            {
                case "Premiere": price += 12;
                    Console.WriteLine("{0:f2} leva", (price * totalSeats));
                    break;
                case "Normal": price += 7.50;
                    Console.WriteLine("{0:f2} leva", (price * totalSeats));
                    break;
                case "Discount": price += 5;
                    Console.WriteLine("{0:f2} leva", (price * totalSeats));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
