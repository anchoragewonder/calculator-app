using System;

using CalculatorApp.Functions;

public class Divide : IFunctionInterface
{
    public float Execute(float first, float second)
    {
        return first / second;
    }
}

