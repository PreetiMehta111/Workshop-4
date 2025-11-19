using System;

class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator class
        Calculator calc = new Calculator();

        // Calling methods
        calc.PrintWelcome();

        int additionResult = calc.Add(10, 5);
        int multiplicationResult = calc.Multiply(10); // num2 uses default = 1

        // Print results
        Console.WriteLine("Addition Result: " + additionResult);
        Console.WriteLine("Multiplication Result: " + multiplicationResult);
    }
}
