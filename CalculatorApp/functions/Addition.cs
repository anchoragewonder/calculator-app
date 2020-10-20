using System;

using CalculatorApp.Functions;

public class Addition : IFunctionInterface
{
    public float Execute(float first, float second)
    {
        return first + second;
    }
}