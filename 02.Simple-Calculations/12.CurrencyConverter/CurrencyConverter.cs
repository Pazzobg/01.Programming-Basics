using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var curr1 = Console.ReadLine();
            var curr2 = Console.ReadLine();

            if (curr1 == "BGN")
            {
                if (curr2 == "USD")
                {
                    Console.WriteLine(Math.Round(amount / 1.79549, 2) + " USD");
                }
                else if (curr2 == "EUR")
                {
                    Console.WriteLine(Math.Round(amount / 1.95583, 2) + " EUR");
                }
                else if (curr2 == "GBP")
                {
                    Console.WriteLine(Math.Round(amount / 2.53405, 2) + " GBP");
                }
            }

            else if (curr1 == "USD")
            {
                if (curr2 == "BGN")
                {
                    Console.WriteLine(Math.Round(amount * 1.79549, 2) + " BGN");
                }
                else if (curr2 == "EUR")
                {
                    Console.WriteLine(Math.Round(amount * 1.79549 / 1.95583, 2) + " EUR");
                }
                else if (curr2 == "GBP")
                {
                    Console.WriteLine(Math.Round(amount * 1.79549 / 2.53405, 2) + " GBP");
                }
            }

            else if (curr1 == "EUR")
            {
                if (curr2 == "USD")
                {
                    Console.WriteLine(Math.Round(amount * 1.95583 / 1.79549, 2) + " USD");
                }
                else if (curr2 == "BGN")
                {
                    Console.WriteLine(Math.Round(amount * 1.95583, 2) + " BGN");
                }
                else if (curr2 == "GBP")
                {
                    Console.WriteLine(Math.Round(amount * 1.95583 / 2.53405, 2) + " GBP");
                }
            }

            else if (curr1 == "GBP")
            {
                if (curr2 == "USD")
                {
                    Console.WriteLine(Math.Round(amount * 2.53405 / 1.79549, 2) + " USD");
                }
                else if (curr2 == "EUR")
                {
                    Console.WriteLine(Math.Round(amount * 2.53405 / 1.95583, 2) + " EUR");
                }
                else if (curr2 == "BGN")
                {
                    Console.WriteLine(Math.Round(amount * 2.53405, 2) + " BGN");
                }
            }
        }
    }
}
