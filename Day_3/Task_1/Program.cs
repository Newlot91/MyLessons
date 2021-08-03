using System;

namespace Task_1
{
    class Program
    {
        /*brood force
         * Task 1. Create a one-dimensional array with digits – 1, 6, 7, 2, 5, 9, 3, 10.
         * Find the min and max elements of the array. Use console to output operations.*/
        static void Main(string[] args)
        {
            int[] numbers = { 1, 6, 7, 2, 5, 9, 3, 10 };
            Console.Write($"Numbers from your array:");
            foreach (int i in numbers) 
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();   
            int minNum = numbers[0]; // 1
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum) minNum = numbers[i];
            }
            Console.WriteLine($"Min.number is {minNum}");
            int maxNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNum) maxNum = numbers[i];
            }
            Console.WriteLine($"Max.number is {maxNum}");
            Console.ReadLine();

        }
    }
}
