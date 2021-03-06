using System;

namespace CalculatorWithTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Calculator!");
            Console.WriteLine("Input first operand: ");
            double firstOperand = Calculator.NumInput();
            Console.WriteLine();
            Console.Write("Input operator (+ - * / % sqrt !) ");

            bool isSecondNeed = Calculator.OperatorInput(out string marhOperator);
            double secondOperand = 0;
            if (isSecondNeed)
            {
                Console.WriteLine("Input scond operand: ");
                secondOperand = Calculator.NumInput();
            }
            double result = 0;

            switch (marhOperator)
            {
                case "+":
                    result = Calculator.Add(firstOperand, secondOperand);
                    break;
                case "-":
                    result = Calculator.Subtract(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Calculator.Multiply(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Calculator.Divide(firstOperand, secondOperand);
                    break;
                case "%":
                    result = Calculator.RestOfDivide(firstOperand, secondOperand);
                    break;
                case "^":
                    result = Calculator.Power(firstOperand, secondOperand);
                    break;
                case "sqrt":
                    result = Calculator.Sqrt(firstOperand);
                    break;
                case "!":
                    result = Calculator.Factorial(firstOperand);
                    break;
                default:
                    Console.WriteLine("no such operator '\\_O_/'");
                    break;
            }
            Console.WriteLine($"Result = {result}");
            Console.ReadLine();
        }
    }
}
