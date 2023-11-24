// See https://aka.ms/new-console-template for more information
using System;
namespace Factorial
{
    internal class Program
    {
       public static void Main(String[]args)
        {
            Console.Write("Enter a +ve number to calculate  factorial: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is: {CalculateFactorial(number)}");
        }
        static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
        
    }
}

