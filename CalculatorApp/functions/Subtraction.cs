using System;

using CalculatorApp.Functions;

public class Subtraction : IFunctionInterface
{
	public float Execute(float first, float second)
	{
        return first - second;
    }
}