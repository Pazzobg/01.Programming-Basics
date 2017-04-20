using System;

namespace _15.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            var minsExam = examHour * 60 + examMinute;
            var minsArrive = arriveHour * 60 + arriveMinute;
            var minutesDifference = minsArrive - minsExam; 

            if (minutesDifference < -30)
                Console.WriteLine("Early");
            else if (minutesDifference > -30 && minutesDifference <= 0)
                Console.WriteLine("On Time");
            else
                Console.WriteLine("Late");

            if (minutesDifference != 0)
            {
                var hours = Math.Abs(minutesDifference / 60);
                var minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (minutesDifference < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }
    }
}
