using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class RectangleAreaTryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                var area = a * b;

                Console.WriteLine(area);
            }

            catch
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
