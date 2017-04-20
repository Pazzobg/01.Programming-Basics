using System;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int playWeekendsHome = int.Parse(Console.ReadLine());
            var weeksSofia = (48 - playWeekendsHome);
            var playSofia = weeksSofia * 0.75;
            var playHoliday = (holidays / 3.0) * 2.0;
            var totalPlay = playWeekendsHome + playSofia + playHoliday;

            if (yearType == "normal")
                Console.WriteLine(Math.Floor(totalPlay));
            else if (yearType == "leap")
                Console.WriteLine(Math.Floor(totalPlay + (totalPlay * 0.15)));
        }
    }
}
