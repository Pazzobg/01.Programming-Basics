using System;

namespace _09.FGrades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double totalGrades = 0;
            double topStudents = 0;
            double FourToFive = 0;
            double ThreeToFour = 0;
            double fail = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                if (grade >= 5) topStudents++;
                else if (grade >= 4) FourToFive++;
                else if (grade >= 3) ThreeToFour++;
                else fail++;
            }
            Console.WriteLine("Top students: {0:f2}%", ((topStudents / students) * 100));
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", ((FourToFive / students) * 100));
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", ((ThreeToFour / students) * 100));
            Console.WriteLine("Fail: {0:f2}%", ((fail / students) * 100));
            Console.WriteLine("Average: {0:f2}", (totalGrades / students)); 
        }
    }
}
