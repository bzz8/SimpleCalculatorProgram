using System;

namespace GitBruh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the calculator program!");
            Console.WriteLine();

            // Input first number
            double num1;
            while (true)
            {
                Console.Write("Please enter the first number: ");
                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            Console.WriteLine();

            // Input operation
            char operation;
            while (true)
            {
                Console.Write("Enter '+' for addition, '-' for subtraction, '*' for multiplication, and '/' for division: ");
                try
                {
                    operation = Convert.ToChar(Console.ReadLine());
                    if ("+-*/".Contains(operation))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid operation. Please enter one of '+', '-', '*', '/'.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid operation. Please enter one of '+', '-', '*', '/'.");
                }
            }
            Console.WriteLine();

            // Input second number
            double num2;
            while (true)
            {
                Console.Write("Please enter the second number: ");
                try
                {
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (operation == '/' && num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero number.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            Console.WriteLine();

            // Perform calculation
            double result = 0;
            switch (operation)
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
                    result = num1 / num2;
                    break;
            }

            // Output result
            Console.WriteLine($"The result is: {num1} {operation} {num2} = {result}");
            Console.WriteLine();

            Console.WriteLine("Thank you for using the calculator program!");
            Console.ReadKey();
        }
    }
}
