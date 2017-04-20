using System;

namespace _04.Problem04
{
    class TrainersSalary
    {
        static void Main()
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double singleSalary = budget / lectures;
            double jelev = 0;
            double royal = 0;
            double roli = 0;
            double trofon = 0;
            double sino = 0;
            double others = 0;

            for (int i = 0; i < lectures; i++)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "jelev": jelev++; break;
                    case "royal": royal++; break;
                    case "roli": roli++; break;
                    case "trofon": trofon++; break;
                    case "sino": sino++; break;
                    default: others++; break;
                }
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", (jelev * singleSalary));
            Console.WriteLine("RoYaL salary: {0:f2} lv", (royal * singleSalary));
            Console.WriteLine("Roli salary: {0:f2} lv", (roli * singleSalary));
            Console.WriteLine("Trofon salary: {0:f2} lv", (trofon * singleSalary));
            Console.WriteLine("Sino salary: {0:f2} lv", (sino * singleSalary));
            Console.WriteLine("Others salary: {0:f2} lv", (others * singleSalary));
        }
    }
}
