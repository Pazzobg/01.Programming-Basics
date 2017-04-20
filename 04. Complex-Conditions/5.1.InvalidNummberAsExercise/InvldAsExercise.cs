using System;

namespace _5._1.InvalidNummberAsExercise
{
    class InvldAsExercise
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var inRange = (number >= 100 && number <= 200 || number == 0);
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
