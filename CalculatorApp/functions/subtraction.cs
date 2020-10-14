using System;

using CalculatorApp.functions;

public class subtract : IFunctionInterface
{
	public static float subnum(float first, float second)
	{
        float answer = first - second;
        return answer;
    }
}

