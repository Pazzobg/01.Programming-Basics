using System;

namespace _02.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double countSegment1 = 0;
            double countSegment2 = 0;
            double countSegment3 = 0;
            double countSegment4 = 0;
            double countSegment5 = 0;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input < 200) countSegment1 += 1;
                else if (input <= 399) countSegment2 += 1;
                else if (input <= 599) countSegment3 += 1;
                else if (input <= 799) countSegment4 += 1;
                else countSegment5 += 1;
            }

            Console.WriteLine("{0:f2}%", ((countSegment1/n)*100));//1
            Console.WriteLine("{0:f2}%", ((countSegment2/n)*100));//2
            Console.WriteLine("{0:f2}%", ((countSegment3/n)*100));//3
            Console.WriteLine("{0:f2}%", ((countSegment4/n)*100));//4
            Console.WriteLine("{0:f2}%", ((countSegment5/n)*100));//5
        }
    }
}
