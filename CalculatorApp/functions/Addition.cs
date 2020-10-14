using System;

using CalculatorApp.functions;

public class Addition : IFunctionInterface
{
    public float Execute(float first, float second)
    {
        float answer = first + second;
        return answer;
    }
}
	
