using System;

namespace _07.SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double peopleTotal = 0.0;
            int carCounter = 0;
            int minibusCounter = 0;
            int smallBusCounter = 0;
            int busCounter = 0;
            int trainCounter = 0;

            for (int i = 0; i < groups; i++)
            {
                int input = int.Parse(Console.ReadLine());
                peopleTotal += input;
                if (input <= 5) carCounter += input;
                else if (input <= 12) minibusCounter += input;
                else if (input <= 25) smallBusCounter += input;
                else if (input <= 40) busCounter += input;
                else trainCounter += input;
            }
            Console.WriteLine("{0:f2}%", ((carCounter / peopleTotal) * 100));
            Console.WriteLine("{0:f2}%", ((minibusCounter / peopleTotal) * 100));
            Console.WriteLine("{0:f2}%", ((smallBusCounter / peopleTotal) * 100));
            Console.WriteLine("{0:f2}%", ((busCounter / peopleTotal) * 100));
            Console.WriteLine("{0:f2}%", ((trainCounter / peopleTotal) * 100));
        }
    }
}
