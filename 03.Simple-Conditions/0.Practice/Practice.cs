using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var words = "";
            var toNineteen = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var twentyToNiNine = new[] {"zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            if (num >= 0 && num < 20)
            {
                Console.WriteLine(toNineteen[num]);
            }
            else if (num >= 20 && num <= 99)
            {
                words = twentyToNiNine[num / 10];

                if (num % 10 != 0)
                {
                    words = words + " " + toNineteen[num % 10];
                    Console.WriteLine(words);
                }
                else
                {
                Console.WriteLine(words);
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
