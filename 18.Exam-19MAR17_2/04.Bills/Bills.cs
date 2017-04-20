using System;

namespace _13.Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 20;
            double net = 15;
            double others = 0;
            double grandTotal = 0;
            double electricityAccumulated = 0;
            double othersAccumulated = 0;

            for (int i = 0; i < n; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                double bills = electricity + water + net;
                others = bills + (bills * 0.20);
                electricityAccumulated += electricity;
                othersAccumulated += others;
                grandTotal += (bills + others);
            }

            Console.WriteLine($"Electricity: {electricityAccumulated:f2} lv");
            Console.WriteLine("Water: {0:f2} lv", water * n);
            Console.WriteLine("Internet: {0:f2} lv", net * n);
            Console.WriteLine($"Other: {othersAccumulated:f2} lv");
            Console.WriteLine($"Average: {(grandTotal / n):f2} lv");
        }
    }
}
