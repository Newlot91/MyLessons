using System;

namespace Task_2
{
    class Program
    {
        /*Task 2. Create a one-dimensional array with digits – 1, 6, 7, 2, 5, 9, 3, 10. 
         * Find only even elements of the array. Use console to output operations.*/
        static void Main(string[] args)
        {
            int[] numbers = { 1, 6, 7, 2, 5, 9, 3, 10 };
            Console.Write($"Numbers from your array:");
            foreach (int i in numbers)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.Write("Even elements of the array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers [i] % 2 != 0)
                {
                    Console.Write(numbers[i]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
