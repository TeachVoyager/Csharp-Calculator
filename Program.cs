// Name: Xaiver Hickey
// Date: 9/30/2024


using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }

        if (op == '+' || op == '-' || op == '*' || (op == '/' && num2 != 0))
            Console.WriteLine($"Result: {result}");
    }
}
