using System;

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var points = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    points += 1;
                }
                else if (text [i] == 'e')
                {
                    points += 2;
                }
                else if (text [i] == 'i')
                {
                    points += 3;
                }
                else if (text[i] == 'o')
                {
                    points += 4;
                }
                else if (text[i] == 'u')
                {
                    points += 5;
                }
            }
            Console.WriteLine(points);
        }
    }
}
