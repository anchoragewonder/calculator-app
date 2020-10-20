using System;

using CalculatorApp.Functions;

public class Multiply : IFunctionInterface
{
    public float Execute(float first, float second)
    {
        return first * second;
    }
}

