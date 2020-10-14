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
            bool appEnd = false;

            Console.WriteLine("Your go to C# calculator");
            Console.WriteLine("-------------------------");

            while (!appEnd)
            {
                
                Console.WriteLine("enter first number:");
                float num1 = float.Parse(Console.ReadLine());
                bool result = float.IsNaN(num1);
                while(result)
                {
                    Console.WriteLine("Please enter a valid number:");
                    num1 = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("enter second number:");
                float num2 = float.Parse(Console.ReadLine());
                while (float.IsNaN(num2))
                {
                    Console.WriteLine("Please enter a valid number:");
                    num2 = float.Parse(Console.ReadLine());
                }

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

                    case "*":
                        answer = new multiply().Execute(num1, num2);
                        break;

                    case "/":
                        while (num2 == 0)
                        {
                            Console.WriteLine("enter non zero number to divide by:");
                            num2 = float.Parse(Console.ReadLine());
                        }
                        answer = new divide().Execute(num1, num2);
                        break;
                }

                Console.WriteLine($"Your answer is: {num1} {oper} {num2} = {answer}");
                Console.WriteLine("Press c and enter to close or enter to continue");

                if(Console.ReadLine() == "c") appEnd = true;
            }
            return;
        }
    }
}
