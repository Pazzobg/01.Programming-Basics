using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            if (km < 20) //TAXI only
            {
                if (time == "day")
                    Console.WriteLine(km * 0.79 + 0.70);
                else
                    Console.WriteLine(km * 0.90 + 0.70);
            }

            else if (km < 100) //BUS into use
                Console.WriteLine(km * 0.09);

            else //TRAIN
                Console.WriteLine(km * 0.06);
        }
    }
}
