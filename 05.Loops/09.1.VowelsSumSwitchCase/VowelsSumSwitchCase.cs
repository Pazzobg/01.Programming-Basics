using System;

namespace _0.Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            var score = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a': score += 1; break;
                    case 'e': score += 2; break;
                    case 'i': score += 3; break;
                    case 'o': score += 4; break;
                    case 'u': score += 5; break;
                }
            }
            Console.WriteLine(score);
        }
    }
}
