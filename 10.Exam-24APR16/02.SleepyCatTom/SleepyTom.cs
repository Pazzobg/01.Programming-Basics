using System;

namespace _13.SleepyCatTom
{
    class SleepyTom
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysWork = 365 - daysOff;
            int playHours = (daysOff * 127) + (daysWork * 63);
            int difference = Math.Abs(30000 - playHours);
            int diffHours = difference / 60;
            int diffMinutes = difference % 60;

            if (playHours<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffHours} hours and {diffMinutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffHours} hours and {diffMinutes} minutes more for play");
            }
        }
    }
}
