using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
            DateTime d2 = date.AddDays(19999);

            Console.WriteLine(d2.ToString("dd-MM-yyyy"));
        }
    }
}
