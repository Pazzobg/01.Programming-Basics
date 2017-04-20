using System;

namespace _17.NumberOperations
{
    class NumberOperations
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            var result = 0.0;
            var oddness = "a";

            if (op == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                    oddness = "even";
                else
                    oddness = "odd";
                Console.WriteLine($"{num1} {op} {num2} = {result} - {oddness}");
            }
            else if (op == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                    oddness = "even";
                else
                    oddness = "odd";
                Console.WriteLine($"{num1} {op} {num2} = {result} - {oddness}");
            }
            else if (op == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                    oddness = "even";
                else
                    oddness = "odd";
                Console.WriteLine($"{num1} {op} {num2} = {result} - {oddness}");
            }

            if ((op == "/" || op == "%") && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }

            else if (op == "/")
            {
                result = num1 / num2;
                Console.WriteLine("{0} {1} {2} = {3:f2}", num1, op, num2, result);
            }
            else if (op == "%")
            {
                result = num1 % num2;
                Console.WriteLine($"{num1} {op} {num2} = {result}");
            }
        }
    }
}
