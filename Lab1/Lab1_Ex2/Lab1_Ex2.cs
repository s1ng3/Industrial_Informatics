using System;
using Lab1_Ex2.Properties;

namespace Lab1_Ex2
{
    public class Lab1_Ex2
    {
        public static void Main(string[] args)
        {
            float a, b;

            Console.Write("Enter the first number (a): ");
            if (float.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Enter the second number (b): ");
                if (float.TryParse(Console.ReadLine(), out b))
                {
                    Operations operations = new Operations();

                    Console.Write("a + b = ");
                    operations.Plus(a, b);
                    Console.Write("\n");

                    Console.Write("a - b = ");
                    operations.Minus(a, b);
                    Console.Write("\n");

                    Console.Write("a * b = ");
                    operations.Multiply(a, b);
                    Console.Write("\n");

                    // Check for division by zero
                    if (b != 0)
                    {
                        Console.Write("a / b = ");
                        operations.Divide(a, b);
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }
        }
    }
}