using System;

namespace _05.SequenceTwoKPlusOne
{
    class SequenceTwoKPlusOne
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num = ((2 * num) + 1))
            {
                Console.WriteLine(num);
            }*/

            //Drug nachin s while loop:

            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = (2 * num) + 1;
            }

        }
    }
}
