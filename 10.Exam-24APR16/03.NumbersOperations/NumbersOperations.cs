using System;

namespace _03.NumbersOperations
{
    class NumbersOperations
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0.0;
            string evenness = "";

            if (op == "+" || op == "-" || op == "*")
            {

            }
            if (op == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0) evenness = "even";
                else evenness = "odd";
                Console.WriteLine($"{num1} + {num2} = {result} - {evenness}");
            }
            else if (op == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0) evenness = "even";
                else evenness = "odd";
                Console.WriteLine($"{num1} - {num2} = {result} - {evenness}");
            }
            else if (op == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0) evenness = "even";
                else evenness = "odd";
                Console.WriteLine($"{num1} * {num2} = {result} - {evenness}");
            }
            else if (op == "/" && num2 != 0)
            {
                result = (double)num1 / num2;
                Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
            }
            else if (op == "%" && num2 != 0)
            {
                result = num1 % num2;
                Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
            }
            else Console.WriteLine($"Cannot divide {num1} by zero");
        }
    }
}
