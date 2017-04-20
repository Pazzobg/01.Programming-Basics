using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1.DifferenceBetweenDates
{
    class DatesDifference
    {
        static void Main(string[] args)
        {
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            Console.WriteLine((endDate - startDate).TotalDays + " days between {0} and {1}", endDate, startDate);
        }
    }
}
