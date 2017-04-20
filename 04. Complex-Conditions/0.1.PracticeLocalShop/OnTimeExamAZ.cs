using System;

namespace _0._1.PracticeLocalShop
{
    class OnTimeExamAZ
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examMinutesTotal = (examHour * 60) + examMin;
            int arriveMinutesTotal = (arriveHour * 60) + arriveMin;

            string arrivalState = "";

            if (arriveMinutesTotal - examMinutesTotal < -30)
            {
                arrivalState = "Early";
            }
            else if ((arriveMinutesTotal - examMinutesTotal >= -30) && (arriveMinutesTotal - examMinutesTotal <= 0))
            {
                arrivalState = "On time";
            }
            else
            {
                arrivalState = "Late";
            }

            Console.WriteLine(arrivalState);

            if (arriveMinutesTotal < examMinutesTotal)
            {
                var diff = examMinutesTotal - arriveMinutesTotal;
                var hourDiff = diff / 60;
                var minuteDiff = diff % 60;

                if (diff / 60 >= 1)
                {
                    if (minuteDiff < 10)
                    {
                        Console.WriteLine(hourDiff + ":0" + minuteDiff + " hours before the start");
                    }
                    else
                    {
                        Console.WriteLine(hourDiff + ":" + minuteDiff + " hours before the start");

                    }
                }
                else
                {
                        Console.WriteLine(minuteDiff + " minutes before the start");
                }
            }

            else if (arriveMinutesTotal > examMinutesTotal)
            {
                var diff = arriveMinutesTotal - examMinutesTotal;
                var hourDiff = diff / 60;
                var minuteDiff = diff % 60;

                if (diff / 60 >= 1)
                {
                    if (minuteDiff < 10)
                    {
                        Console.WriteLine(hourDiff + ":0" + minuteDiff + " hours after the start");
                    }
                    else
                    {
                        Console.WriteLine(hourDiff + ":" + minuteDiff + " hours after the start");

                    }
                }
                else
                {
                        Console.WriteLine(minuteDiff + " minutes after the start");
                }
            }
        }
    }
}
