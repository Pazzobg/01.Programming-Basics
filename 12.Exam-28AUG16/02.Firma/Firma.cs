using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersOvt = int.Parse(Console.ReadLine());

            var daysAvailable = days - (days * 0.10);
            var productionTime = Math.Floor(daysAvailable * 8);
            var hoursOvt = workersOvt * (days * 2);
            var hoursProduction = productionTime + hoursOvt;

            if (hoursProduction >= hoursNeeded)
            {
                var timeLeft = hoursProduction - hoursNeeded;
                Console.WriteLine($"Yes!{Math.Floor(timeLeft)} hours left.");
            }
            else
            {
                var timeShort = hoursNeeded - hoursProduction;
                Console.WriteLine($"Not enough time!{Math.Floor(timeShort)} hours needed.");
            }
        }
    }
}
