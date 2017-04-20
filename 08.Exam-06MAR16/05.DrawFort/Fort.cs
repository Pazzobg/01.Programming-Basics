using System;

namespace _01.DrawFort
{
    class Fort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = n - 2;
            int spaceBody = (2 * n) - 2;
            int bottomLine = n / 2;
            int bottomSpace = (2 * n) - 4 - ((n / 2) * 2);
            int singleTower = ((2 * n) - 2 - bottomSpace) / 2;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', bottomLine), new string('_', bottomSpace));
            for (int i = 0; i < l; i++)
            {
                if (i == (l - 1)) Console.WriteLine("|{0}{1}{0}|", new string(' ', singleTower), new string('_', bottomSpace));
                else Console.WriteLine("|{0}|", new string(' ', spaceBody));
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', bottomLine), new string(' ', bottomSpace));
        }
    }
}
