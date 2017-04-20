using System;

namespace _2._21.DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var usdPerDay = double.Parse(Console.ReadLine());
            var exchRate = double.Parse(Console.ReadLine());

            var monthSallary = workDays * usdPerDay;
            var bonus = monthSallary * 2.5;
            var ttlIncome = (12 * monthSallary) + bonus;
            var tax = (ttlIncome / 100) * 25;
            var incomeAfterTaxes = ttlIncome - tax;
            var incomeBgnAnnual = incomeAfterTaxes * exchRate;

            Console.WriteLine(Math.Round((incomeBgnAnnual / 365), 2));
        }
    }
}
