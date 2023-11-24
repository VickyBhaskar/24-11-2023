// See https://aka.ms/new-console-template for more information
using System;
namespace Array
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[]  arr = new int[5];
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine($"Enter element of index {i+1} ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int number in arr)
            {
                sum += number;
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine($"Sum of Array Elements: {sum}");
            Console.WriteLine($"Average of Array Elements: {average}");
        }
    }
}
