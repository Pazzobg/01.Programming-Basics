using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputDate = Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(InputDate, "dd-MM-yyyy", null);

            Console.WriteLine(date1.ToString("dd-MM-yyyy"));
        }
    }
}
