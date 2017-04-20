using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            string tikets = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double totalSum = money * people;
            double sumForTikets = 0;

            if (people >= 1 && people < 5)
            {
                totalSum = money - money * 0.75;
            }
            else if (people >= 5 && people < 10)
            {
                totalSum = money - money * 0.60;
            }
            else if (people >= 10 && people < 25)
            {
                totalSum = money - money * 0.50;
            }
            else if (people >= 25 && people < 50)
            {
                totalSum = money - money * 0.40;
            }
            else if (people >= 50)
            {
                totalSum = money - money * 0.25;
            }
            switch (tikets)
            {
                case "VIP":

                    sumForTikets = people * 499.99;
                    if (sumForTikets >= totalSum)
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", sumForTikets - totalSum);
                    }
                    else if (sumForTikets < totalSum)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", sumForTikets - totalSum);
                    }
                    break;
                case "Normal":
                    {
                        sumForTikets = people * 249.99;
                        if (sumForTikets >= totalSum)
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", sumForTikets - totalSum);
                        }
                        else if (sumForTikets < totalSum)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", totalSum - sumForTikets);
                        }
                    }
                    break;
            }

        }
    }
}