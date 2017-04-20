using System;
using System.Threading;

namespace _001.IvenaHearts
{
    class IvenaHearts
    {
        static void Main(string[] args)
        {
            var c = (char)3;

            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(c);
                    Thread.Sleep(150);
                }
                Console.WriteLine();
            }
        }
    }
}
