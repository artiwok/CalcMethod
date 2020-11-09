using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalcMethod
{
    class Program
    {
        static void Calc_1()
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                char action;

                try
                {
                    Console.WriteLine("Enter First Number");

                    NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };

                    firstValue = double.Parse(Console.ReadLine(), numberFormatInfo);

                    Console.WriteLine("Enter Second Number");

                    secondValue = double.Parse(Console.ReadLine(), numberFormatInfo);
                }
                catch (Exception)
                {

                    Console.WriteLine("Not a number!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Choose action: '+', '-', '*', '/', '%' ");

                action = char.Parse(Console.ReadLine());

                switch (action)
                {
                    case '+':
                        Console.WriteLine("The result is " + (firstValue + secondValue));
                        break;
                    case '-':
                        Console.WriteLine("The result is " + (firstValue - secondValue));
                        break;
                    case '*':
                        Console.WriteLine("The result is " + (firstValue * secondValue));
                        break;
                    case '/':
                        if (secondValue == 0)
                            Console.WriteLine("Division by zero!");
                        else
                            Console.WriteLine("The result is " + (firstValue / secondValue));
                        break;
                    case '%':
                        Console.WriteLine("The result is " + (firstValue % secondValue));
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }

                Console.ReadLine();

            }
        }

        static double Calc_2(double num_1, double num_2, char action)
        {
            double result = 0;

            if (action == '+')
            {
                result = num_1 + num_2;
            }
            else if (action == '-')
            {
                result = num_1 - num_2;
            }
            else if (action == '*')
            {
                result = num_1 * num_2; ;
            }
            else if (action == '/')
            {
                if (num_2 == 0)
                {
                    Console.WriteLine("Division by zero!");
                }
                else
                {
                    result = num_1 / num_2;
                }

            }
            else if (action == '%')
            {
                result = num_1 % num_2;
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }

            Console.WriteLine($"The result is: {result}");

            Console.ReadLine();

            return result;

        }

        static void Main(string[] args)
        {
            //Calc_1();

            Calc_2(4, 0, '/');
        }
    }
}
