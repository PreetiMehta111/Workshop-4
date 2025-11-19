using System;

public class Calculator
{
    // 1. Void method PrintWelcome()
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // 2. Method Add(int num1, int num2)
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // 3. Method Multiply(int num1, int num2 = 1)
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
