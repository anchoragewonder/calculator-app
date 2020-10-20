using System;

namespace CalculatorApp
{
    class Program
    {

        const string INTRODUCTION = "Your go to C# calculator";
        const string BARS = "-------------------------";
        const string CLOSE = "Press q and enter to close or enter to continue";

        const string INVALID_NUMBER = "Please enter a valid number:";
        const string NON_ZERO_NUMBER = "Enter non zero number to divide by:";
        const string ENTER_OPERATOR = "Enter operator,  +  -  *  /  :";

        const string FIRST_NUMBER = "Enter first number:";
        const string SECOND_NUMBER = "Enter second number:";

        static void Main(string[] args)
        {
            bool appEnd = false;

            Console.WriteLine(INTRODUCTION);
            Console.WriteLine(BARS);

            while (!appEnd)
            {
                float num1 = GetNumber(FIRST_NUMBER);
                float num2 = GetNumber(SECOND_NUMBER);
                string oper = GetOperator();

                float answer = CalculateAnswer(num1, num2, oper);
                Console.WriteLine($"Your answer is: {num1} {oper} {num2} = {answer}");

                Console.WriteLine(CLOSE);
                if (Console.ReadLine().ToLower() == "q") appEnd = true;
            }
            return;
        }

        private static float GetNumber(string text)
        {
            Console.WriteLine(text);
            while (!float.TryParse(Console.ReadLine(), out _))
            {
                Console.WriteLine(INVALID_NUMBER);
            }
            return float.Parse(Console.ReadLine());
        }

        private static string GetOperator()
        {
            Console.WriteLine(ENTER_OPERATOR);
            string oper = Console.ReadLine();

            while (!(oper.Contains("+") || oper.Contains("/") || oper.Contains("*") || oper.Contains("-")))
            {
                Console.WriteLine(ENTER_OPERATOR);
                oper = Console.ReadLine();
            }
            return oper;
        }

        private static float CalculateAnswer(float num1, float num2, string oper)
        {
            float answer;
            switch (oper)
            {
                default:
                    answer = 0;
                    break;

                case "+":
                    answer = new Addition().Execute(num1, num2);
                    break;

                case "-":
                    answer = new Subtraction().Execute(num1, num2);
                    break;

                case "*":
                    answer = new Multiply().Execute(num1, num2);
                    break;

                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine(NON_ZERO_NUMBER);
                        num2 = float.Parse(Console.ReadLine());
                    }
                    answer = new Divide().Execute(num1, num2);
                    break;
            }
            return answer;
        }
    }
}
