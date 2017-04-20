using System;

namespace _21.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workdays = int.Parse(Console.ReadLine());

            int workhoursEffective = workers * 8 * workdays;
            int diff = Math.Abs(hoursNeeded - workhoursEffective);
            int penalties = diff * workdays;

            if (hoursNeeded<=workhoursEffective)
            {
                Console.WriteLine($"{diff} hours left");
            }
            else
            {
                Console.WriteLine($"{diff} overtime\nPenalties: {penalties}");
            }
        }
    }
}
