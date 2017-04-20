using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().ToLower();
            var input2 = Console.ReadLine().ToLower();

            if (input1 == input2)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
