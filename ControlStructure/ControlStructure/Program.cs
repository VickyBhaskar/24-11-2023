// See https://aka.ms/new-console-template for more information
using System;
namespace ControlStructure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}, is even number "); 
            }
            else
            {
                Console.WriteLine($"{num}, is odd number ");
            }
            Console.ReadKey();
        }
    }
}
