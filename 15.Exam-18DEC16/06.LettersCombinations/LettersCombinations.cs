using System;

namespace _23.LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char startChar = Convert.ToChar(Console.ReadLine().ToLower());
            char endChar = Convert.ToChar(Console.ReadLine().ToLower());
            char avoidChar = Convert.ToChar(Console.ReadLine().ToLower());


            //char startChar = char.Parse(Console.ReadLine().ToLower());
            //char endChar = char.Parse(Console.ReadLine().ToLower());
            //char avoidChar = char.Parse(Console.ReadLine().ToLower());

            //string start = Console.ReadLine().ToLower();
            //char startChar = start[0];
            //string end = Console.ReadLine().ToLower();
            //char endChar = end[0];
            //string avoid = Console.ReadLine().ToLower();
            //char avoidChar = avoid[0];
            int combinations = 0;

            for (char i = startChar; i <= endChar; i++)
            {
                for (char j = startChar; j <= endChar; j++)
                {
                    for (char k = startChar; k <= endChar; k++)
                    {
                        if ((i != avoidChar) && (j != avoidChar) && (k != avoidChar))
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinations++;
                        }
                    }
                }
            }
            Console.Write(combinations);
            Console.WriteLine();
        }
    }
}
