using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", null);
            DateTime newdate = date.AddDays(999);

            Console.WriteLine(newdate.ToString("dd-MM-yyyy"));
        }
    }
}
