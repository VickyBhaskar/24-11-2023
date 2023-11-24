// See https://aka.ms/new-console-template for more information
using System;
namespace ExceptionHandling
{
    internal class Program
    {
       public static void Main(String[]args )
        {
            int age;
            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }
            } while (true);

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}
