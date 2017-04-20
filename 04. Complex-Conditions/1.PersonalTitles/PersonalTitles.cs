using System;

namespace _1.PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine().ToLowerInvariant();

            if (age >= 16)
            {
                if (gender == "m")
                    Console.WriteLine("Mr.");
                else if (gender == "f")
                    Console.WriteLine("Ms.");
            }

            else
            {
                if (gender == "m")
                    Console.WriteLine("Master");
                else if (gender == "f")
                    Console.WriteLine("Miss");
            }
        }
    }
}
