using System;

namespace _18.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double initialSpeed = double.Parse(Console.ReadLine());
            double time1 = double.Parse(Console.ReadLine()) / 60;
            double time2 = double.Parse(Console.ReadLine()) / 60;
            double time3 = double.Parse(Console.ReadLine()) / 60;
            double speedFaster = initialSpeed + (initialSpeed * 0.10);
            double speedSlower = speedFaster - (speedFaster * 0.05);

            var distanceInitial = initialSpeed * time1;
            var distFaster = speedFaster * time2;
            var distSlower = speedSlower * time3;
            var distanceTotal = distanceInitial + distFaster + distSlower;
            Console.WriteLine("{0:f2}", distanceTotal);
        }
    }
}
