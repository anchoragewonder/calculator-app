using System;

using CalculatorApp.functions;

public class addition : IFunctionInterface
{
    public float Execute(float first, float second)
    {
        float answer = first + second;
        return answer;
    }
}
	
