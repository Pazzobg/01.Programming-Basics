using System;

namespace _12.GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double score = 0;
            double zeroToNine = 0;
            double tenToNineteen = 0;
            double twentyToTwentyNine = 0;
            double thirtyToThirtyNine = 0;
            double fourtyToFifty = 0;
            double invalid = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 50)
                {
                    score /= 2;
                    invalid++;
                }
                else if (input >=0 && input < 10)
                {
                    score += input * 0.20;
                    zeroToNine++;
                }
                else if (input < 20)
                {
                    score += input * 0.30;
                    tenToNineteen++;
                }
                else if (input < 30)
                {
                    score += input * 0.40;
                    twentyToTwentyNine++;
                }
                else if (input < 40)
                {
                    score += 50;
                    thirtyToThirtyNine++;
                }
                else
                {
                    score += 100;
                    fourtyToFifty++;
                }
            }
            Console.WriteLine($"{score:f2}");
            Console.WriteLine("From 0 to 9: {0:f2}%", (zeroToNine / n) * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", (tenToNineteen / n) * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", (twentyToTwentyNine / n) * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", (thirtyToThirtyNine / n) * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", (fourtyToFifty / n) * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", (invalid / n) * 100);
        }
    }
}
