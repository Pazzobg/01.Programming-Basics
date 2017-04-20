using System;

namespace _5.InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200 || number == 0)
            {

            }
            else
                Console.WriteLine("invalid");
        }
    }
}
