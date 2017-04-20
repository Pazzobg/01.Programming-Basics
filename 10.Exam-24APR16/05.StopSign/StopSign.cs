using System;

namespace _03.StopSign
{
    class StopSign
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int underLineTop = (2 * n) + 1;
            int insideLine = (2 * n) - 1;
            int stopLine = (2 * n) - 3;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underLineTop));
            dots--;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', insideLine));
                dots--;
                insideLine += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', stopLine));
            for (int i = 0; i < n; i++)
            {
                dots = i; ;
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', insideLine));
                insideLine -= 2;
            }
        }
    }
}
