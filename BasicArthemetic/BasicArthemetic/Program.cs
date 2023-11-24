// See https://aka.ms/new-console-template for more information
using System;
namespace BasicArthemetic
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st inetger number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st inetger number ");
            int num2 = int.Parse(Console.ReadLine());
            //Addtion
            int sum = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
            // Subtraction
            int sub = num1 - num2;
            Console.WriteLine($"Subtraction: {num1} - {num2} = {sub}");

            // Multiplication
            int product = num1 * num2;
            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

            // Division
            if (num2 != 0)
            {
                double quotient = (double)num1 / num2;
                Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is undefined.");
            }

            // Modulus
            if (num2 != 0)
            {
                int remainder = num1 % num2;
                Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");
            }
            else
            {
                Console.WriteLine("Modulus by zero is undefined.");
            }
        }
    }
}
