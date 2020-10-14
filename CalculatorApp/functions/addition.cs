using System;

using CalculatorApp.functions;

public class addition : IFunctionInterface
{
    public static float sumnum(float first, float second)
    {
        float answer = first + second;
        return answer;
    }
}
	
