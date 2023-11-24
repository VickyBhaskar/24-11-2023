// See https://aka.ms/new-console-template for more information
using System;
namespace VariableAndUSerInput
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your name");
            String userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName} ");
        }
    } 
}