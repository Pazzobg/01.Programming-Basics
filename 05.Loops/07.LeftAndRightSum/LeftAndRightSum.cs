using System;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var leftInput = int.Parse(Console.ReadLine());
                leftSum += leftInput;
            }

            for (int i = 0; i < n; i++)
            {
                var rightInput = int.Parse(Console.ReadLine());
                rightSum += rightInput;
            }

            var diff = Math.Abs(leftSum - rightSum);

            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = "+leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = "+diff);
            }
        }
    }
}
