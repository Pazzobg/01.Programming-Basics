using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                string resultNum = "";

                int firstDigit = num % 10;
                switch (firstDigit)
                {
                    case 1:
                        resultNum = "one";
                        break;
                    case 2:
                        resultNum = "two";
                        break;
                    case 3:
                        resultNum = "three";
                        break;
                    case 4:
                        resultNum = "four";
                        break;
                    case 5:
                        resultNum = "five";
                        break;
                    case 6:
                        resultNum = "six";
                        break;
                    case 7:
                        resultNum = "seven";
                        break;
                    case 8:
                        resultNum = "eight";
                        break;
                    case 9:
                        resultNum = "nine";
                        break;
                }

                num = num / 10;
                int secondDigit = num % 10;

                switch (secondDigit)
                {
                    case 1:
                        switch (firstDigit)
                        {
                            case 0:
                                resultNum = "ten";
                                break;
                            case 1:
                                resultNum = "eleven";
                                break;
                            case 2:
                                resultNum = "twelve";
                                break;
                            case 3:
                                resultNum = "thirteen";
                                break;
                            case 4:
                                resultNum = "fourteen";
                                break;
                            case 5:
                                resultNum = "fiveteen";
                                break;
                            case 6:
                                resultNum = "sixteen";
                                break;
                            case 7:
                                resultNum = "seventeen";
                                break;
                            case 8:
                                resultNum = "eightteen";
                                break;
                            case 9:
                                resultNum = "nineteen";
                                break;
                        }
                        break;
                    case 2:
                        resultNum = "twenty " + resultNum;
                        break;
                    case 3:
                        resultNum = "thirty " + resultNum;
                        break;
                    case 4:
                        resultNum = "fourty " + resultNum;
                        break;
                    case 5:
                        resultNum = "fifty " + resultNum;
                        break;
                    case 6:
                        resultNum = "sixty " + resultNum;
                        break;
                    case 7:
                        resultNum = "seventy " + resultNum;
                        break;
                    case 8:
                        resultNum = "eighty " + resultNum;
                        break;
                    case 9:
                        resultNum = "ninety " + resultNum;
                        break;
                }

                num = num / 10;

                if (num > 0)
                {
                    resultNum = "one hundred";
                }

                Console.WriteLine(resultNum);
            }

            Console.ReadLine();
        }
    }
}