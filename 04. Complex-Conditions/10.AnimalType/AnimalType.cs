using System;

namespace _10.AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                default:
                    Console.WriteLine("unknown");
                    break;
                case "dog": Console.WriteLine("mammal");
                    break;
                case "crocodile": 
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
            }
        }
    }
}
