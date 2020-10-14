using System;

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

            switch (oper)
            {
                case "+":
                    float ans = addition.sumnum(num1, num2);
                    Console.WriteLine("Your answer is:" + ans );
                    break;
            }

        }
    }
}
