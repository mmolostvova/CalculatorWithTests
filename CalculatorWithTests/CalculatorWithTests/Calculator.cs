using System;
using System.Collections.Generic;

namespace CalculatorWithTests
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double RestOfDivide(double a, double b)
        {
            return a % b;
        }

        public static double Divide(double a, double b)
        {
            while (b == 0)
            {
                Console.WriteLine("You can't divide by zero!");
                return 0;
            }
            return a / b;
        }

        public static double Factorial(double a)
        {
            double result = 1;
            while (a  > 12 || a < 1)
            {
                Console.WriteLine("Number is too big. Choose number from 1 to 12, please!");
                return 0;
            }
            for (int i = 1; i <= a; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static double Power(double n1, double n2)
        {
            double res = 1;
            for (int i = 1; i <= n2; i++)
            {
                res *= n1;
            }
            return res;
        }

        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public static double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = double.TryParse(numberString, out double numberDouble);
            while (!isDoubleInput)
            {
                Console.WriteLine("Wrong input! Try again.");
                numberString = Console.ReadLine();
                isDoubleInput = double.TryParse(numberString, out numberDouble);
            }
            return numberDouble;
        }

        public static bool OperatorInput(out string mathOperator)
        {
            mathOperator = Console.ReadLine();
            List<string> operatorsWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorsWithOneArgument = new List<string> { "sqrt", "!" };

            while (true)
            {
                if (operatorsWithSecondArgument.Contains(mathOperator))
                {
                    return true;
                }
                else if (operatorsWithOneArgument.Contains(mathOperator))
                {
                    return false;
                }
                Console.WriteLine();
                Console.WriteLine("Wrong input! Try again.");
            }
        }
    }
}
