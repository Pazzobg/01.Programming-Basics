using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlusFifteen
{
    class TimePlusFifteen
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var time = minutes + 15;

            if (time <= 59)
            {
                hours = hours;
                time = time; 
            }
            else
            {
                hours = hours + 1;
                time = time - 60;
            }

            if (hours <= 23)
                hours = hours;
            else
                hours = 0;

            if (time < 10)
                Console.WriteLine(hours + ":0" + time);
            else
                Console.WriteLine(hours + ":" + time);
        }
    }
}
