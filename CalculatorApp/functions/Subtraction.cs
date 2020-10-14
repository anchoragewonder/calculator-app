using System;

using CalculatorApp.functions;

public class Subtraction : IFunctionInterface
{
	public float Execute(float first, float second)
	{
        float answer = first - second;
        return answer;
    }
}