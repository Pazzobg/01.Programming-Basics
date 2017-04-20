using System;

namespace _1.OnTimeForTheExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int timeExam = (hourExam * 60) + minuteExam;
            int timeArrival = (hourArrive * 60) + minuteArrive;
            var difference = timeExam - timeArrival;
            var hoursDifference = Math.Abs(difference / 60);
            var minsDifference = Math.Abs(difference % 60);

            if (difference > 30) Console.WriteLine("Early");
            else if (difference <= 30 && difference >= 0) Console.WriteLine("On time");
            else Console.WriteLine("Late");

            if (difference > 0)
            {
                if (hoursDifference > 0)
                    Console.WriteLine("{0}:{1:00} hours before the start", hoursDifference, minsDifference);
                else Console.WriteLine("{0} minutes before the start", minsDifference);
            }
            else if (difference < 0)
            {
                if (hoursDifference > 0) Console.WriteLine("{0}:{1:00} hours after the start", hoursDifference, minsDifference);
                else Console.WriteLine("{0} minutes after the start", minsDifference);
            }
        }
    }
}
