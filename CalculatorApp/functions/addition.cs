using CalculatorApp;
using System;

public class addition
{
    public void getnum()
    {

        Console.WriteLine("enter first number:");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("enter operator,  +  -  *  /  :");
        char oper = char.Parse(Console.ReadLine());

        Console.WriteLine("enter second number:");
        float num2 = float.Parse(Console.ReadLine());
    }
    
    public static void sumnum(float first, float second)
    {
        float ans = first + second;

    }
}
	
