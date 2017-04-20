using System;

namespace _5._23.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int nDays = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var untreatedPatients = 0;
            var nDoctors = 7;

            for (int i = 1; i <= nDays; i++)
            {
                if (i % 3 == 0 && (untreatedPatients > treatedPatients))
                {
                    nDoctors++;
                }

                int patients = int.Parse(Console.ReadLine());

                if (patients <= nDoctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    treatedPatients += nDoctors;
                    untreatedPatients += (patients - nDoctors);
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
