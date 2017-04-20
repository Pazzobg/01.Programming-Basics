using System;

namespace _5._22.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearLast = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;

            for (int i = 1800; i <= yearLast; i++)
            {
                if (i %2 == 0)
                {
                    moneyNeeded += 12000; 
                }
                else
                {
                    var currentAge = (i - 1800) + 18;
                    moneyNeeded += 12000 + (50 * currentAge);
                }
            }
            var diff = Math.Abs(moneyNeeded - heritage);

            if (heritage >= moneyNeeded)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", diff);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", diff);
            }
        }
    }
}
