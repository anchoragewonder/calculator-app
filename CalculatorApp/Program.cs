using System;
using System.IO.Pipes;

namespace CalculatorApp
{
    interface Inumbers
    {
        public void getnum();
    }

    class Program 
    {
      

    static void Main(string[] args)
        {
            Console.WriteLine("Your go to C# calculator");

            Console.WriteLine("enter first number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter operator,  +  -  *  /  :");
            string oper = (Console.ReadLine());

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
            }

            Console.WriteLine("Your answer is:" + answer);
        }
    }
}
